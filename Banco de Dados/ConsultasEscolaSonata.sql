SELECT a.nome_alu AS Nome_Aluno,
    r.nome_resp AS Nome_Responsavel
FROM Alunos AS a
LEFT JOIN
    Responsavel_aluno r ON a.fk_id_responsavel = r.id_responsavel;
    
-- 1.2
SELECT c.nome_cur AS Nome_Curso,
	p.nome_pro AS Professor_Ativo
	FROM Professor_Curso AS pc
	INNER JOIN  Professores AS p ON pc.fk_id_professor = p.id_professor
	RIGHT JOIN Cursos AS c ON pc.fk_id_curso = c.id_curso
	ORDER BY c.nome_cur;
    
-- 2
SELECT id_pagamento, valor_pag, mesReferencia_pag, data_pag
FROM Pagamentos WHERE fk_id_contrato IN (
    SELECT id_contrato FROM Contratos
    WHERE fk_id_curso = (
	SELECT id_curso FROM Cursos WHERE nome_cur = 'Violão Popular')
);

-- 2.1
SELECT c.id_contrato, a.nome_alu AS Nome_do_Aluno,
    m.nome_mod AS Modalidade,
    m.valorBase_mod AS Valor_Modalidade
	FROM Contratos AS c INNER JOIN
    Modalidades AS m ON c.fk_id_modalidade = m.id_modalidade
	INNER JOIN Alunos a ON c.fk_id_aluno = a.id_aluno
	WHERE
    m.valorBase_mod > (SELECT AVG(valorBase_mod) FROM Modalidades);
    
-- 3
SELECT r.nome_resp AS Nome_do_Responsavel,
    COUNT(a.id_aluno) AS Qtdd_Alunos
	FROM Responsavel_aluno AS r
	INNER JOIN Alunos AS a ON r.id_responsavel = a.fk_id_responsavel
	GROUP BY r.id_responsavel, r.nome_resp
	ORDER BY Qtdd_Alunos DESC;
    
-- 3.1
SELECT
    tp.descricao_pgto AS Metodo_Pagamento,
    SUM(p.valor_pag) AS Total_Arrecadado
	FROM Pagamentos AS p
	INNER JOIN
    Tipo_pagamento AS tp ON p.fk_id_tipoPgto = tp.id_tipo_pgto
	GROUP BY tp.descricao_pgto
	HAVING SUM(p.valor_pag) > 500;
    
-- 4
SELECT
    t.nome_turma AS "Nome da Turma",
    c.nome_cur AS "Curso",
    t.diaSemana_tur AS "Dia da Semana",
    t.horarioInicio_tur AS "Horário de Início",
    s.nome_sala AS "Local (Sala)"
FROM Turmas AS t
INNER JOIN Cursos AS c ON t.fk_id_curso = c.id_curso
INNER JOIN Salas AS s ON t.fK_id_sala = s.id_sala
WHERE t.status_tur = 'Aberta'
ORDER BY FIELD(t.diaSemana_tur, 'Segunda-feira', 'Terça-feira', 'Quarta-feira', 
'Quinta-feira', 'Sexta-feira', 'Sábado', 'Domingo'),
t.horarioInicio_tur;
-- uso de FIELD para definir uma sequencia personalizada dos dias da semana