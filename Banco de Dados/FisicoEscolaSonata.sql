CREATE DATABASE EscolaSonata;
USE EscolaSonata;
-- DROP DATABASE EscolaSonata;

-- responsáveis por alunos
CREATE TABLE Responsavel_aluno(
	id_responsavel INT PRIMARY KEY AUTO_INCREMENT,
    nome_resp VARCHAR(100) NOT NULL,
    cpf_resp VARCHAR(15) NOT NULL UNIQUE,
    dataNasc_resp DATE,
    email_resp VARCHAR(100) NOT NULL,
    rg_resp VARCHAR(20),
    telefone_resp VARCHAR(20),
    parentesco_resp VARCHAR(15)
);

-- tipos de pagamento
CREATE TABLE Tipo_pagamento(
	id_tipo_pgto INT PRIMARY KEY AUTO_INCREMENT,
    descricao_pgto VARCHAR(50) NOT NULL
);

-- salas
CREATE TABLE Salas(
	id_sala INT PRIMARY KEY AUTO_INCREMENT,
    nome_sala VARCHAR(50) NOT NULL,
    capacidade_sala INT,
    equipamentos_sala VARCHAR(100)
);


-- alunos
CREATE TABLE Alunos(
	id_aluno INT PRIMARY KEY AUTO_INCREMENT,
    nome_alu VARCHAR(100) NOT NULL,
    cpf_alu VARCHAR(15) UNIQUE,
    dataNasc_alu DATE NOT NULL,
    email_alu VARCHAR(100), 
    rg_alu VARCHAR(20),
    telefone_alu VARCHAR(20),
    fk_id_responsavel INT,
    FOREIGN KEY(fk_id_responsavel) REFERENCES Responsavel_aluno(id_responsavel)
);
CREATE TABLE Cursos(
	id_curso INT PRIMARY KEY AUTO_INCREMENT,
    nome_cur VARCHAR(50) NOT NULL,
    cargaHoraria_cur VARCHAR(20) NOT NULL,
    duracaoAula_cur VARCHAR(20)
);

-- professores
CREATE TABLE Professores(
	id_professor INT PRIMARY KEY AUTO_INCREMENT,
    nome_pro VARCHAR(100) NOT NULL,
    cpfCnpj_pro VARCHAR(20) NOT NULL UNIQUE,
    dataAdmissao_pro DATE NOT NULL
);

-- tabela associativa para cursos e professores que os ministram
CREATE TABLE Professor_Curso(
	id_prof_curso INT PRIMARY KEY AUTO_INCREMENT,
    fk_id_professor INT NOT NULL,
    fk_id_curso INT NOT NULL,
    FOREIGN KEY(fk_id_professor) REFERENCES Professores(id_professor),
    FOREIGN KEY(fk_id_curso) REFERENCES Cursos(id_curso)
);


-- cargos dos funcionários
CREATE TABLE Cargos(
	id_cargo INT PRIMARY KEY AUTO_INCREMENT,
    nome_cargo VARCHAR(50) NOT NULL,
    nivelAcesso_car VARCHAR(50) NOT NULL,
    salarioBase_car DECIMAL(10, 2)
);

-- funcionários
CREATE TABLE Funcionarios(
	id_funcionario INT PRIMARY KEY AUTO_INCREMENT,
    nome_fun VARCHAR(100) NOT NULL,
    cpf_fun VARCHAR(15) NOT NULL UNIQUE,
    dataNasc_fun DATE,
    email_fun VARCHAR(100) NOT NULL,
    telefone_fun VARCHAR(20),
    dataAdmissao_fun DATE NOT NULL,
    fk_id_cargo INT NOT NULL,
    FOREIGN KEY(fk_id_cargo) REFERENCES Cargos(id_cargo)
);

-- caixas
CREATE TABLE Caixas(
	id_caixa INT PRIMARY KEY AUTO_INCREMENT,
    saldoInicial_cai DECIMAL(10, 2) NOT NULL, 
    saldoFinal_cai DECIMAL(10, 2),
    dataAbertura_cai DATE NOT NULL,
    dataFechamento_cai DATE,
    fk_id_funcionario INT NOT NULL,
    FOREIGN KEY(fk_id_funcionario) REFERENCES Funcionarios(id_funcionario)
);

-- instrumentos
CREATE TABLE Instrumentos(
	id_instrumento INT PRIMARY KEY AUTO_INCREMENT,
    nome_intrumento VARCHAR(50) NOT NULL,
    tipo_ins VARCHAR(50)
);

-- turmas
CREATE TABLE Turmas(
	id_turma INT PRIMARY KEY AUTO_INCREMENT,
	nome_turma VARCHAR(50),
    horarioInicio_tur TIME NOT NULL,
    horarioFim_tur TIME,
    capacidade_tur INT,
    diaSemana_tur VARCHAR(20) NOT NULL,
    status_tur VARCHAR(50),
    fk_id_curso INT NOT NULL,
    fK_id_sala INT NOT NULL,
    FOREIGN KEY(fk_id_curso) REFERENCES Cursos(id_curso),
    FOREIGN KEY(fk_id_sala) REFERENCES Salas(id_sala)
);

-- modalidades
CREATE TABLE Modalidades(
	id_modalidade INT PRIMARY KEY AUTO_INCREMENT,
    nome_mod VARCHAR(50) NOT NULL,
    descricao_mod TEXT,
    valorBase_mod DECIMAL(10, 2)
);

-- contratos
CREATE TABLE Contratos(
	id_contrato INT PRIMARY KEY AUTO_INCREMENT,
    dataIinicio_con DATE NOT NULL,
    dataFim_con DATE,
    dataVencimentoParcela_con DATE NOT NULL,
    status_con VARCHAR(50),
    fk_id_modalidade INT NOT NULL,
    fk_id_curso INT NOT NULL,
    fk_id_aluno INT NOT NULL,
    FOREIGN KEY(fk_id_modalidade) REFERENCES Modalidades(id_modalidade),
    FOREIGN KEY(fk_id_curso) REFERENCES Cursos(id_curso),
    FOREIGN KEY(fk_id_aluno) REFERENCES Alunos(id_aluno)
);

-- pagamentos
CREATE TABLE Pagamentos(
	id_pagamento INT PRIMARY KEY AUTO_INCREMENT,
    valor_pag DECIMAL(10, 2) NOT NULL,
    mesReferencia_pag VARCHAR(20) NOT NULL,
    data_pag DATE NOT NULL,
    status_pag VARCHAR(20),
    fk_id_contrato INT NOT NULL,
    fk_id_tipoPgto INT NOT NULL,
    fk_id_caixa INT NOT NULL,
    FOREIGN KEY(fk_id_caixa) REFERENCES Caixas(id_caixa),
    FOREIGN KEY(fk_id_contrato) REFERENCES Contratos(id_contrato),
    FOREIGN KEY(fk_id_tipoPgto) REFERENCES Tipo_pagamento(id_tipo_pgto)
);

-- tabela associativa para alunos e turmas
CREATE TABLE Matricula(
	id_matricula INT PRIMARY KEY AUTO_INCREMENT,
    status_matricula VARCHAR(50),
    frequencia INT,
    fk_id_aluno INT NOT NULL,
    fk_id_turma INT NOT NULL,
    FOREIGN KEY(fk_id_aluno) REFERENCES Alunos(id_aluno),
    FOREIGN KEY(fk_id_turma) REFERENCES Turmas(id_turma)
);

-- tabela associativa para professor e turma
CREATE TABLE Professor_Turma(
	id_prof_turma INT PRIMARY KEY AUTO_INCREMENT,
    fk_id_professor INT NOT NULL,
    fk_id_turma INT NOT NULL,
    FOREIGN KEY(fk_id_professor) REFERENCES Professores(id_professor),
    FOREIGN KEY(fk_id_turma) REFERENCES Turmas(id_turma)
);

-- Tabela Leads (para interessados em aulas)
CREATE TABLE Leads(
    id_lead INT PRIMARY KEY AUTO_INCREMENT,
    nome_lead VARCHAR(100) NOT NULL,
    dataNasc_lead DATE,
    telefone_lead VARCHAR(20) NOT NULL,
    email_lead VARCHAR(100) NOT NULL UNIQUE, 
    observacoes_lead TEXT,
    dataCaptacao_lead DATETIME DEFAULT CURRENT_TIMESTAMP NOT NULL, 
    status_lead VARCHAR(50) NOT NULL, 
    nomeResponsavel_lead VARCHAR(100) 
);

-- aulas experimentais
CREATE TABLE Aula_experimental(
	id_aulaEXP INT PRIMARY KEY AUTO_INCREMENT,
    dataHora_exp DATETIME NOT NULL,
    duracaoAula_exp TIME NOT NULL,
    status_exp VARCHAR(20),
    observacoes_exp TEXT,
    fk_id_sala INT NOT NULL,
    fk_id_instrumento INT NOT NULL,
    fk_id_professor INT NOT NULL,
    fk_id_lead INT NOT NULL,
    FOREIGN KEY(fk_id_sala) REFERENCES Salas(id_sala),
    FOREIGN KEY(fk_id_instrumento) REFERENCES Instrumentos(id_instrumento),
    FOREIGN KEY(fk_id_professor) REFERENCES Professores(id_professor),
    FOREIGN KEY(fk_id_lead) REFERENCES Leads(id_lead)
);

-- salas disponiveis
CREATE TABLE Disponibilidade_sala(
	id_disponibilidade INT PRIMARY KEY AUTO_INCREMENT,
    diaDaSemana_dis VARCHAR(20) NOT NULL,
    horarioInicio_dis TIME NOT NULL,
    horarioFim_dis TIME NOT NULL,
    status_dis VARCHAR(50),
    fk_id_sala INT NOT NULL,
    FOREIGN KEY(fk_id_sala) REFERENCES Salas(id_sala)
);

-- professores disponiveis
CREATE TABLE Disponibilidade_professor(
	id_disponibilidade INT PRIMARY KEY AUTO_INCREMENT,
    diaDaSemana_dis VARCHAR(20) NOT NULL,
    horarioInicio_dis TIME NOT NULL,
    horarioFim_dis TIME NOT NULL,
    status_dis VARCHAR(50),
    fk_id_professor INT NOT NULL,
    FOREIGN KEY(fk_id_professor) REFERENCES Professores(id_professor)
);

-----------------------------------------------------------------
SELECT a.nome_alu AS Nome_Aluno,
    r.nome_resp AS Nome_Responsavel
FROM Alunos AS a
LEFT JOIN
    Responsavel_aluno r ON a.fk_id_responsavel = r.id_responsavel;
    
-- 1.2
SELECT c.nome_cur AS Nome_Curso,
	p.nome_pro AS Professor_Ativo
	FROM Professor_Curso AS pc
	INNER JOIN  Professores p ON pc.fk_id_professor = p.id_professor
	RIGHT JOIN Cursos c ON pc.fk_id_curso = c.id_curso
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