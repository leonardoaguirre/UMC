create table situacao(
id serial primary key,
	descricao varchar(50)
);
create table produto(
id serial primary key,
	descricao varchar(50),
	quantidade integer,
	situacao integer,
	constraint id_situacao_fk foreign key(situacao) references situacao(id)
);

insert into situacao(descricao) values ('ativo'),('inativo');
insert into produto(descricao,quantidade,situacao) values
('computador gamer', 20, 1),
('mesa gamer', 45, 1),
('monitor gamer', 35, 1),
('teclado gamer', 32, 2),
('cadeira gamer', 52, 1);