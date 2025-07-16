-- Tabela: Cargos
INSERT INTO Cargos (nome_cargo, nivelAcesso_car, salarioBase_car) VALUES
('Secretário(a)', 'Básico', 2200.00),
('Auxiliar Administrativo', 'Básico', 2500.00),
('Gerente', 'Total', 5500.00),
('Coordenador Pedagógico', 'Administrativo', 4500.00),
('Diretor', 'Total', 10000.00);
-- a empresa não possui 10 tipos de cargos para funcionários

-- Tabela: Cursos
INSERT INTO Cursos (nome_cur, cargaHoraria_cur, duracaoAula_cur) VALUES
('Violão Popular', '44h', '1h'),
('Piano Clássico', '96h', '1h30'),
('Bateria', '44h', '1h'),
('Canto', '44', '1h'),
('Clarinete', '36h', '1h'),
('Saxofone', '36h', '1h'),
('Guitarra', '36h', '1h'),
('Teclado', '44h', '1h'),
('Musicalização', '44h', '1h'),
('Contrabaixo', '44h', '1h'),
('Teoria Musical', '24h', '1h30');

-- Tabela: Instrumentos
INSERT INTO Instrumentos (nome_intrumento, tipo_ins) VALUES
('Violão de Nylon', 'Cordas'),
('Violão de Aço', 'Cordas'),
('Piano Digital', 'Teclas'),
('Bateria Acústica', 'Percussão'),
('Contrabaixo', 'Cordas'),
('Guitarra', 'Cordas'),
('Clarinete', 'Sopro'),
('Saxofone', 'Sopro'),
('Piano Acústico', 'Teclas');

-- Tabela: Modalidades
INSERT INTO Modalidades (nome_mod, descricao_mod, valorBase_mod) VALUES
('Pacote Personal', 'Aula particular com foco total no aluno.', 350.00),
('Pacote Class', 'Aula para dois alunos, ideal para amigos ou irmãos.', 250.00),
('Musicalização Infantil', 'Turmas com 3 a 5 alunos.', 190.00);

-- Tabela: Salas
INSERT INTO Salas (nome_sala, capacidade_sala, equipamentos_sala) VALUES
('Sala 1 - Cordas', 5, 'Violões, Cadeiras, Apoio de pé'),
('Sala 2 - Teclas', 3, 'Piano Digital, Teclado'),
('Sala 3 - Bateria', 1, 'Bateria Acústica, Abafadores'),
('Sala 5 - Musicalização Infantil', 10, 'Lousa, Cadeiras, Caixa de Som'),
('Sala 6 - Canto', 5, 'Lousa, Cadeiras, Piano'),
('Sala 7 - Estúdio', 10, 'Computador, Mesa de Captação, Sistema de Som'),
('Sala 8 - Teórica', 10, 'Lousa, Cadeiras, Sistema de Som');

-- Tabela: Tipo_pagamento
INSERT INTO Tipo_pagamento (descricao_pgto) VALUES
('Boleto Bancário'),
('Cartão de Crédito'),
('PIX'),
('Cartão de Débito'),
('Cheque'),
('Dinheiro');

-- Tabela: Leads (Interessados)
INSERT INTO Leads 
(nome_lead, dataNasc_lead, telefone_lead, email_lead, observacoes_lead, dataCaptacao_lead, status_lead, nomeResponsavel_lead) VALUES
('Carlos Andrade', '1990-04-15', '(11) 98888-1111', 'carlos.a@email.com', 'Interessado em violão popular.', NOW(), 'Agendado', NULL),
('Mariana Costa', '1988-07-22', '(21) 97777-2222', 'mari.costa@email.com', NULL, NOW(), 'Convertido', NULL),
('Pedro Almeida', '1995-11-05', '(81) 96666-3333', 'pedro.almeida@email.com', 'Agendado para teste de bateria.', NOW(), 'Agendado', 'Juliana Almeida'),
('Fernanda Lima', '1992-02-28', '(48) 95555-4444', 'fe.lima@email.com', NULL, NOW(), 'Contato Feito', NULL),
('Lucas Ferreira', '2000-09-10', '(31) 94444-5555', 'lucas.ferreira@email.com', 'Interessado em teclado.', NOW(), 'Agendado', NULL),
('Beatriz Mendes', '1994-06-12', '(41) 93333-6666', 'beatriz.mendes@email.com', NULL, NOW(), 'Convertido', NULL),
('André Souza', '1987-03-17', '(51) 92222-7777', 'andre.souza@email.com', 'Quer experimentar canto.', NOW(), 'Agendado', 'Paulo Souza'),
('Juliana Pires', '1993-10-03', '(61) 91111-8888', 'juliana.pires@email.com', NULL, NOW(), 'Contato Feito', NULL),
('Elias Silva', '1999-01-25', '(61) 91111-8888', 'elias.silva@email.com', 'Interessado em musicalização.', NOW(), 'Contato Feito', NULL),
('Rafael Rocha', '1985-12-19', '(71) 90000-9999', 'rafael.rocha@email.com', NULL, NOW(), 'Agendado', 'Cláudia Rocha');

-- Tabela: Funcionarios
INSERT INTO Funcionarios (nome_fun, cpf_fun, dataNasc_fun, email_fun, telefone_fun, dataAdmissao_fun, fk_id_cargo) VALUES
('João Silva', '111.222.333-44', '1980-05-10', 'joao.silva@escola.com', '(11) 99999-1111', '2022-01-15', 1),
('Maria Oliveira', '222.333.444-55', '1975-08-22', 'maria.oliveira@escola.com', '(21) 98888-2222', '2020-05-20', 2),
('Carlos Mendes', '444.555.666-77', NULL, 'carlos.mendes@escola.com', '(31) 97777-3333', '2019-08-01', 4),
('Fernanda Lima', '555.666.777-88', '1990-07-05', 'fernanda.lima@escola.com', '(41) 96666-4444', '2021-02-18', 1),
('Paulo Ferreira', '666.777.888-99', '1978-11-30', 'paulo.ferreira@escola.com', '(51) 95555-5555', '2018-07-25', 2),
('Juliana Pires', '777.888.999-00', NULL, 'juliana.pires@escola.com', '(61) 94444-6666', '2022-11-05', 5),
('Roberta Dias', '888.999.000-11', '1979-09-19', 'roberta.dias@escola.com', '(71) 93333-7777', '2020-09-14', 4),
('Ricardo Tavares', '999.000.111-22', '1988-02-25', 'ricardo.tavares@escola.com', '(81) 92222-8888', '2017-04-12', 3),
('Luciana Costa', '000.111.222-33', NULL, 'luciana.costa@escola.com', '(91) 91111-9999', '2023-06-30', 2),
('Alencar Morete', '047.170.942-55', '2001-06-17', 'morete.alencar@escola.com', '(21) 90000-0000', '2022-02-14', 3),
('Ana Souza', '333.444.555-66', NULL, 'ana.souza@escola.com', '(31) 98888-1010', '2023-03-10', 3);

-- Tabela: Professores
INSERT INTO Professores (nome_pro, cpfCnpj_pro, dataAdmissao_pro) VALUES
('Ricardo Mendes', '444.555.666-77', '2021-02-01'),
('Carla Pereira', '555.666.777-88', '2022-08-10'),
('Bruno Rocha', '666.777.888-99', '2023-01-20'),
('Sofia Ribeiro', '777.888.999-00', '2023-06-01'),
('Ricardo Mendes', '444.555.766-77', '2021-02-01'),
('Carla Pereira', '555.636.777-88', '2022-08-10'),
('Bruno Rocha', '666.277.888-99', '2023-01-20'),
('Sofia Ribeiro', '777.858.999-00', '2023-06-01'),
('Felipe Almeida', '888.991.000-11', '2024-02-15'),
('Gabriela Nunes', '999.100.111-22', '2024-03-22'),
('Eduardo Tavares', '000.101.222-33', '2024-04-18');

-- Tabela: Responsavel_aluno
INSERT INTO Responsavel_aluno (nome_resp, cpf_resp, email_resp, parentesco_resp) VALUES
('Marcos Valente', '123.123.123-12', 'marcos.v@email.com', 'Pai'),
('Julia Pereira', '234.234.234-23', 'julia.p@email.com', 'Mãe'),
('Fábio Lima', '345.345.345-34', 'fabio.l@email.com', 'Pai'),
('Cláudia Souza', '456.456.456-45', 'claudia.s@email.com', 'Mãe'),
('Rodrigo Pires', '567.567.567-56', 'rodrigo.p@email.com', 'Pai'),
('Patrícia Gomes', '678.678.678-67', 'patricia.g@email.com', 'Mãe'),
('Henrique Dias', '789.789.789-78', 'henrique.d@email.com', 'Pai'),
('Daniela Martins', '901.901.901-90', 'daniela.m@email.com', 'Mãe'),
('Eduardo Barbosa', '012.012.012-01', 'eduardo.b@email.com', 'Pai'),
('Elaine Costa', '890.890.890-89', 'elaine.c@email.com', 'Mãe');

-- Tabela: Caixas (um caixa aberto)
INSERT INTO Caixas (saldoInicial_cai, saldoFinal_cai, dataAbertura_cai, dataFechamento_cai, fk_id_funcionario) VALUES
(500.00, 1200.00, '2025-07-10', '2025-07-11', 1),
(600.00, 1100.00, '2025-07-09', '2025-07-10', 2),
(450.00, 900.00,  '2025-07-08', '2025-07-09', 3),
(700.00, 1300.00, '2025-07-07', '2025-07-08', 4),
(550.00, 1050.00, '2025-07-06', '2025-07-07', 5),
(800.00, 1500.00, '2025-07-05', '2025-07-06', 6),
(400.00, 800.00,  '2025-07-04', '2025-07-05', 7),
(750.00, 1400.00, '2025-07-03', '2025-07-04', 8),
(500.00, 1000.00, '2025-07-02', '2025-07-03', 9),
(650.00, 1250.00, '2025-07-01', '2025-07-02', 10);

-- Tabela: Alunos
INSERT INTO Alunos (
  nome_alu, cpf_alu, dataNasc_alu, email_alu, rg_alu, telefone_alu, fk_id_responsavel) VALUES
('Lucas Valente', NULL, '2010-05-12', 'lucas.v@email.com', 'MG123456', '(31) 99999-1111', 1),
('Beatriz Pereira', NULL, '2008-09-20', 'bia.p@email.com', 'SP234567', '(11) 98888-2222', 2),
('Gabriel Lima', NULL, '2012-02-25', 'gabi.l@email.com', 'RJ345678', '(21) 97777-3333', 3),
('Camila Santos', '111.222.333-44', '1999-11-10', 'camila.s@email.com', 'DF456789', '(61) 96666-4444', NULL),
('Tiago Alves', '222.333.444-55', '2001-07-30', 'tiago.a@email.com', 'SP567890', '(11) 95555-5555', NULL),
('Fernanda Souza', NULL, '2011-03-15', 'fernanda.s@email.com', 'RS678901', '(51) 94444-6666', 4),
('Vinícius Pires', NULL, '2009-12-05', 'vinicius.p@email.com', 'PR789012', '(41) 93333-7777', 5),
('Larissa Gomes', NULL, '2013-06-21', 'larissa.g@email.com', 'BA890123', '(71) 92222-8888', 6),
('Diego Dias', NULL, '2010-08-17', 'diego.d@email.com', 'PE901234', '(81) 91111-9999', 7),
('Mariana Costa', NULL, '2007-04-11', 'mariana.c@email.com', 'CE012345', '(85) 90000-0000', 8),
('Renato Lopes', '333.444.555-66', '2002-01-23', 'renato.l@email.com', 'MG123457', '(31) 99998-1111', NULL),
('Amanda Ferreira', '444.555.666-77', '2000-10-09', 'amanda.f@email.com', 'SP234568', '(11) 98887-2222', NULL),
('Isabela Valente', NULL, '2011-09-14', 'isabela.v@email.com', 'RJ345679', '(21) 97776-3333', 1),
('Matheus Valente', NULL, '2013-02-20', 'matheus.v@email.com', 'DF456780', '(61) 96665-4444', 1),
('Caio Pereira', NULL, '2009-04-08', 'caio.p@email.com', 'SP567891', '(11) 95554-5555', 2),
('Helena Pereira', NULL, '2012-11-23', 'helena.p@email.com', 'RS678902', '(51) 94443-6666', 2),
('Rafaela Lima', NULL, '2014-07-30', 'rafaela.l@email.com', 'PR789013', '(41) 93332-7777', 3),
('Gustavo Lima', NULL, '2016-03-05', 'gustavo.l@email.com', 'BA890124', '(71) 92221-8888', 3),
('Lucas Souza', NULL, '2008-12-12', 'lucas.souza@email.com', 'PE901235', '(81) 91110-9999', 4),
('Amanda Gomes', NULL, '2010-06-18', 'amanda.g@email.com', 'CE012346', '(85) 90000-0001', 6),
('Bruno Gomes', NULL, '2013-01-11', 'bruno.g@email.com', 'MG123458', '(31) 99997-1111', 6),
('Carolina Dias', NULL, '2011-10-25', 'carolina.d@email.com', 'SP234569', '(11) 98886-2222', 7);

-- Tabela: Professor_Curso (associando professores a cursos)
INSERT INTO Professor_Curso (fk_id_professor, fk_id_curso) VALUES
(1, 1),(1, 5),
(2, 2),(2, 8),
(3, 7),(4, 4),
(4, 6),(5, 5),
(5, 10),(6, 9),
(3, 3); 

-- Tabela: Turmas
INSERT INTO Turmas (nome_turma, horarioInicio_tur, horarioFim_tur, capacidade_tur, diaSemana_tur, status_tur, fk_id_curso, fK_id_sala) VALUES
('Violão Iniciante Seg/Qua',      '14:00:00', '15:00:00', 10, 'Segunda-feira', 'Aberta',     1, 1), 
('Piano Intermediário Ter/Qui',   '16:00:00', '17:30:00', 15, 'Terça-feira',   'Aberta',     2, 2), 
('Bateria Individual Sex',        '10:00:00', '11:00:00',  5, 'Sexta-feira',   'Aberta',     3, 3), 
('Teoria Musical Sáb',            '09:00:00', '10:30:00', 20, 'Sábado',        'Aberta',     5, 4), 
('Canto Individual Qua',          '18:00:00', '19:00:00',  5, 'Quarta-feira',  'Planejada',  4, 1), 
('Clarinete Básico Ter/Qui',      '15:00:00', '16:00:00', 10, 'Terça-feira',   'Aberta',     5, 2),  
('Saxofone Avançado Seg/Qua',     '17:00:00', '18:00:00',  8, 'Segunda-feira', 'Aberta',     6, 3),  
('Guitarra Rock Qua/Sex',         '19:00:00', '20:00:00', 15, 'Quarta-feira',  'Aberta',     7, 4), 
('Teclado Popular Seg/Qua',       '11:00:00', '12:00:00', 10, 'Quarta-feira',  'Aberta',     8, 1),  
('Musicalização Infantil Sáb',    '10:30:00', '11:30:00', 15, 'Sábado',        'Aberta',     9, 2),  
('Contrabaixo Groove Ter',        '20:00:00', '21:00:00',  8, 'Terça-feira',   'Planejada', 10, 3);  

-- Tabela: Contratos
INSERT INTO Contratos (dataIinicio_con, dataFim_con, dataVencimentoParcela_con, status_con, fk_id_modalidade, fk_id_curso, fk_id_aluno) VALUES
('2024-02-01', '2025-02-01', '2025-02-10', 'Ativo', 1, 1, 1),
('2024-03-01', '2025-03-01', '2025-03-10', 'Ativo', 1, 2, 2),
('2024-02-15', '2025-02-15', '2025-02-10', 'Ativo', 3, 1, 3),
('2024-04-01', '2025-04-01', '2025-04-10', 'Ativo', 3, 5, 4),
('2024-05-01', '2025-05-01', '2025-05-10', 'Ativo', 3, 5, 5),
('2024-06-01', '2025-06-01', '2025-06-10', 'Ativo', 2, 3, 6),
('2024-07-01', '2025-07-01', '2025-07-10', 'Ativo', 2, 4, 7),
('2024-08-01', '2025-08-01', '2025-08-10', 'Ativo', 1, 6, 8),
('2024-09-01', '2025-09-01', '2025-09-10', 'Inativo', 1, 7, 9),
('2024-10-01', '2025-10-01', '2025-10-10', 'Ativo', 3, 8, 10);

-- Tabela: Matricula
INSERT INTO Matricula (status_matricula, frequencia, fk_id_aluno, fk_id_turma) VALUES
('Ativo', 95, 1, 1),
('Ativo', 88, 2, 2),
('Ativo', 92, 3, 1),
('Ativo', 85, 4, 4),
('Ativo', 80, 5, 4),
('Ativo', 78, 6, 3),
('Ativo', 90, 7, 5),
('Inativo', 45, 8, 6),
('Ativo', 82, 9, 7),
('Ativo', 87, 10, 8);

-- Tabela: Professor_Turma
INSERT INTO Professor_Turma (fk_id_professor, fk_id_turma) VALUES
(1, 1), (2, 2),
(3, 3), (1, 4),
(4, 5), (5, 6),
(6, 7), (1, 8),
(2, 9), (3, 10);

-- Tabela: Pagamentos
INSERT INTO Pagamentos (valor_pag, mesReferencia_pag, data_pag, status_pag, fk_id_contrato, fk_id_tipoPgto, fk_id_caixa) VALUES
(350.00, 'JUN/2025', '2025-06-09', 'Confirmado', 1, 3, 1),
(350.00, 'JUL/2025', '2025-07-08', 'Confirmado', 1, 3, 1),
(350.00, 'JUL/2025', '2025-07-10', 'Confirmado', 2, 2, 1),
(180.00, 'JUL/2025', '2025-07-05', 'Confirmado', 3, 1, 1),
(200.00, 'AUG/2025', '2025-08-10', 'Confirmado', 6, 2, 2),
(400.00, 'SEP/2025', '2025-09-15', 'Pendente', 7, 3, 3),
(150.00, 'JUN/2025', '2025-06-20', 'Confirmado', 9, 1, 4),
(300.00, 'JUL/2025', '2025-07-12', 'Confirmado', 10, 3, 5),
(250.00, 'JUN/2025', '2025-06-30', 'Confirmado', 4, 2, 6),
(275.00, 'JUL/2025', '2025-07-20', 'Pendente', 5, 3, 7);

-- Tabela: Aula_experimental
INSERT INTO Aula_experimental (dataHora_exp, duracaoAula_exp, status_exp, observacoes_exp, fk_id_sala, fk_id_instrumento, fk_id_professor, fk_id_lead) VALUES
('2025-07-14 10:00:00', '00:45:00', 'Agendada', 'Interesse em violão popular.', 1, 1, 1, 1),
('2025-07-15 11:00:00', '00:45:00', 'Agendada', 'Quer testar piano e teclado.', 2, 3, 2, 2),
('2025-07-16 10:00:00', '00:45:00', 'Agendada', 'Pai agendou para aula de bateria.', 3, 4, 3, 3),
('2025-07-17 15:00:00', '00:45:00', 'Agendada', 'Interesse em canto.', 4, 5, 4, 4),
('2025-06-20 16:00:00', '00:45:00', 'Realizada', 'Gostou da aula, possível conversão.', 1, 2, 5, 5),
('2025-06-22 14:00:00', '00:45:00', 'Realizada', 'Aluno convertido com sucesso.', 2, 5, 6, 6),
('2025-07-01 09:00:00', '00:45:00', 'Cancelada', 'Cliente cancelou por motivos pessoais.', 3, 4, 7, 7),
('2025-07-02 18:00:00', '00:45:00', 'Agendada', 'Aula de violão com a professora Gabriela.', 1, 1, 6, 8),
('2025-07-19 10:00:00', '01:00:00', 'Agendada', 'Aula de teclado para o lead Carlos.', 2, 5, 2, 9),
('2025-07-21 17:00:00', '00:30:00', 'Agendada', 'Aula rápida de canto para a lead Mariana.', 4, 5, 4, 10);

-- Tabela: Disponibilidade_sala
INSERT INTO Disponibilidade_sala (diaDaSemana_dis, horarioInicio_dis, horarioFim_dis, status_dis, fk_id_sala) VALUES
('Segunda-feira', '08:00:00', '12:00:00', 'Livre', 1),
('Segunda-feira', '14:00:00', '18:00:00', 'Livre', 1),
('Terça-feira', '09:00:00', '13:00:00', 'Livre', 2),
('Terça-feira', '14:00:00', '18:00:00', 'Livre', 2),
('Quarta-feira', '10:00:00', '14:00:00', 'Livre', 3),
('Quinta-feira', '08:00:00', '18:00:00', 'Livre', 4),
('Sexta-feira', '09:00:00', '12:00:00', 'Livre', 5),
('Sexta-feira', '14:00:00', '19:00:00', 'Livre', 5),
('Sábado', '09:00:00', '13:00:00', 'Livre', 6),
('Sábado', '09:00:00', '17:00:00', 'Livre', 7);

-- Tabela: Disponibilidade_professor
INSERT INTO Disponibilidade_professor (diaDaSemana_dis, horarioInicio_dis, horarioFim_dis, status_dis, fk_id_professor) VALUES
('Segunda-feira', '13:00:00', '20:00:00', 'Disponível', 1), 
('Terça-feira', '09:00:00', '17:00:00', 'Disponível', 2), 
('Quarta-feira', '08:00:00', '14:00:00', 'Disponível', 3), 
('Quinta-feira', '10:00:00', '18:00:00', 'Disponível', 4),
('Segunda-feira', '08:00:00', '12:00:00', 'Disponível', 5),
('Terça-feira', '13:00:00', '21:00:00', 'Disponível', 6),
('Quarta-feira', '15:00:00', '20:00:00', 'Disponível', 7),
('Sexta-feira', '09:00:00', '18:00:00', 'Disponível', 8), 
('Sábado', '09:00:00', '13:00:00', 'Disponível', 9),
('Segunda-feira', '10:00:00', '16:00:00', 'Disponível', 10), 
('Quarta-feira', '09:00:00', '19:00:00', 'Disponível', 11);

