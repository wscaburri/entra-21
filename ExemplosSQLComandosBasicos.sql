CREATE TABLE trabalhos(
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	titulo VARCHAR(100),
	subtitulo VARCHAR(50),
	descricao TEXT, -- armazenar textos grandes
	data_publicacao DATETIME2, -- data e hora
	tipo VARCHAR(15)
);

INSERT INTO trabalhos (titulo, subtitulo, descricao, data_publicacao, tipo)
	VALUES ('A melhor pizza do mundo', 'Como degustar uma pizza de calabresa', 
	'Grande descrição aki', '1994-06-04', 'Receita');

INSERT INTO trabalhos (titulo, subtitulo, descricao, data_publicacao, tipo)
	VALUES ('Clean Code', 'Como trabalhar melhor no seu dia a dia', 
	'utilizar var no lugar de tipo primitivos, identar seu código, utilizar constantes', '2000-03-20', 'Leitura técnica');

INSERT INTO trabalhos (titulo, subtitulo, descricao, data_publicacao, tipo)
	VALUES ('Pudim com ovo', 'Aprenda o que não fazer na sua vida', 
	'Jogue o pudim no lixo e faça um ovo', '2022-07-06', 'Receita');

INSERT INTO trabalhos (titulo, subtitulo, descricao, data_publicacao, tipo)
	VALUES ('Estrutura de dados', 'Como sofrer sem saber, porém é necessário', 
	'Importante para aprender fifo, lifo, fefo, listas encadeadas', '1980-05-11', 'Leitura técnica');

INSERT INTO trabalhos (titulo, subtitulo, descricao, data_publicacao, tipo)
	VALUES ('Strogonoff de frango', 'A vitória da batata palha', 
	'Compre frango e batata palha, jogue na panela, acenda o fogo, espera 5 minutinhos e ta pronto o sorvetinho', '2000-09-10', 'Receita');

SELECT id, titulo, subtitulo, descricao, data_publicacao, tipo FROM trabalhos;

-- Concatenar informação de duas colunas
SELECT CONCAT (titulo, ' - ', subtitulo) AS 'Título completo' FROM trabalhos;

-- Consultar a descrição limitando a quantidade de caracteres
SELECT 
	titulo AS 'Título', 
	CONCAT (SUBSTRING (descricao, 0, 20), '...') AS 'Descrição' 
	FROM trabalhos;

-- Consultar os trabalhos filtrando por ano de publicação entre 1990 até 2010
SELECT id, titulo, data_publicacao 
	FROM trabalhos
	WHERE 
		YEAR(data_publicacao) >= 1990 AND
		YEAR(data_publicacao) <= 2010;

-- Consultar data publicação formato BR huehue
-- BR: dia/mes/ano
SELECT id, titulo, 
	CONCAT(
		DAY(data_publicacao), '/',
		MONTH(data_publicacao), '/',
		YEAR(data_publicacao))
	FROM trabalhos;

-- Consultar data publicação formatando no padrão BR, utilizando função para isso
SELECT id, titulo, FORMAT(data_publicacao, 'dd/MM/yyyy') 
	FROM trabalhos;

-- Limitar a consulta para dois registros
SELECT TOP(2) id, titulo FROM trabalhos;

-- Apresentar o código, nome, preço, se está favoritado, filtrando por Placa mãe ou Placa de video do maior preço para o menor.
-- SELECT TOP(20) id, nome, preco, favoritado
--	FROM produtos
--	WHERE categoria = 'Placa mãe' OR categoria = 'Placa de video'
--	ORDER BY preco DESC;

-- Consulta com paginação, apresentando 2 registros da página 1
SELECT id, titulo
	FROM trabalhos
	ORDER BY id
	OFFSET 0 ROWS FETCH NEXT 2 ROWS ONLY;

-- Consulta com paginação, apresentando 2 registros da página 2
SELECT id, titulo
	FROM trabalhos
	ORDER BY id
	OFFSET 2 ROWS FETCH NEXT 2 ROWS ONLY;

-- Consulta com paginação, apresentando 2 registros da página 3
SELECT id, titulo
	FROM trabalhos
	ORDER BY id
	OFFSET 4 ROWS FETCH NEXT 2 ROWS ONLY;

--------------------------------------------------------------------

-- Exercício 01

CREATE TABLE pessoas(
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(100),
	cpf VARCHAR(14),
	rg VARCHAR(12),
	data_de_nascimento DATETIME2,
	idade INTEGER
);

INSERT INTO pessoas (nome, cpf, rg, data_de_nascimento, idade)
	VALUES ('Erick Bryan Enrico Vieira', '699.734.958-70', '90.745.276-0', '1989-05-28', '29');

INSERT INTO pessoas (nome, cpf, rg, data_de_nascimento, idade)
	VALUES ('Samuel Ruan Dias', '802.790.194-40', '55.318.691-7', '1988-02-08', '30');

INSERT INTO pessoas (nome, cpf, rg, data_de_nascimento, idade)
	VALUES ('Fábio Benjamin Souza', '522.445.349-60', '54.715.232-2', '1970-03-22', '48');

INSERT INTO pessoas (nome, cpf, rg, data_de_nascimento, idade)
	VALUES ('Elias Miguel Aparicio', '293.928.821-65', '293.928.821-65', '1986-06-07', '32');

INSERT INTO pessoas (nome, cpf, rg, data_de_nascimento, idade)
	VALUES ('Alexandre Gustavo Cardoso', '617.408.878-24', '8.888.574-4', '2003-04-15', '15');

INSERT INTO pessoas (nome, cpf, rg, data_de_nascimento, idade)
	VALUES ('Kauê Lucca Duarte', '943.163.990-47', '46.977.509-9', '1965-06-15', '53');

INSERT INTO pessoas (nome, cpf, rg, data_de_nascimento, idade)
	VALUES ('Marcos Bryan Guilherme Mendes', '955.129.235-95', '84.050.077-4', '2015-02-06', '3');

INSERT INTO pessoas (nome, cpf, rg, data_de_nascimento, idade)
	VALUES ('Benedito Pedro Carlos da Mota', '510.505.472-50', '43.588.124-3', '1981-04-19', '37');

INSERT INTO pessoas (nome, cpf, rg, data_de_nascimento, idade)
	VALUES ('Luís Igor Barbosa', '370.570.311-06', '40.651.407-0', '2013-05-06', '5');

INSERT INTO pessoas (nome, cpf, rg, data_de_nascimento, idade)
	VALUES ('José Heitor Ramos', '675.624.925-81', '83.962.258-2', '1965-04-11', '53');

INSERT INTO pessoas (nome, cpf, rg, data_de_nascimento, idade)
	VALUES ('Lucca Tiago Galvão', '788.124.508-57', '3.293.335-6', '1977-06-17', '41');

INSERT INTO pessoas (nome, cpf, rg, data_de_nascimento, idade)
	VALUES ('Tiago Edson Oliveira', '389.969.352-39', '8.198.446-9', '1977-06-09', '41');

INSERT INTO pessoas (nome, cpf, rg, data_de_nascimento, idade)
	VALUES ('Enrico Julio Fábio Martins', '529.078.166-83', '99.886.242-3', '2017-03-11', '1');

INSERT INTO pessoas (nome, cpf, rg, data_de_nascimento, idade)
	VALUES ('', '', '', '', '');

INSERT INTO pessoas (nome, cpf, rg, data_de_nascimento, idade)
	VALUES ('Oliver Victor Benjamin da Mota', '798.556.805-02', '5.103.578-9', '1985-03-27', '33');

INSERT INTO pessoas (nome, cpf, rg, data_de_nascimento, idade)
	VALUES ('Bryan Caio Lopes', '213.217.201-30', '12.949.454-9', '1970-06-18', '48');





















