PGDMP     !                     x            sistema    9.6.12    9.6.12     d           0    0    ENCODING    ENCODING         SET client_encoding = 'LATIN1';
                       false            e           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                       false            f           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                       false            g           1262    16393    sistema    DATABASE     ?   CREATE DATABASE sistema WITH TEMPLATE = template0 ENCODING = 'UTF8' LC_COLLATE = 'Portuguese_Brazil.1252' LC_CTYPE = 'Portuguese_Brazil.1252';
    DROP DATABASE sistema;
             postgres    false                        2615    2200    public    SCHEMA        CREATE SCHEMA public;
    DROP SCHEMA public;
             postgres    false            h           0    0    SCHEMA public    COMMENT     6   COMMENT ON SCHEMA public IS 'standard public schema';
                  postgres    false    3                        3079    12387    plpgsql 	   EXTENSION     ?   CREATE EXTENSION IF NOT EXISTS plpgsql WITH SCHEMA pg_catalog;
    DROP EXTENSION plpgsql;
                  false            i           0    0    EXTENSION plpgsql    COMMENT     @   COMMENT ON EXTENSION plpgsql IS 'PL/pgSQL procedural language';
                       false    1            ?            1259    16440    produto    TABLE     ?   CREATE TABLE public.produto (
    id integer NOT NULL,
    descricao character varying(50),
    quantidade integer,
    situacao integer
);
    DROP TABLE public.produto;
       public         postgres    false    3            ?            1259    16438    produto_id_seq    SEQUENCE     w   CREATE SEQUENCE public.produto_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 %   DROP SEQUENCE public.produto_id_seq;
       public       postgres    false    188    3            j           0    0    produto_id_seq    SEQUENCE OWNED BY     A   ALTER SEQUENCE public.produto_id_seq OWNED BY public.produto.id;
            public       postgres    false    187            ?            1259    16434    situacao    TABLE     _   CREATE TABLE public.situacao (
    id integer NOT NULL,
    descricao character varying(50)
);
    DROP TABLE public.situacao;
       public         postgres    false    3            ?            1259    16432    situacao_id_seq    SEQUENCE     x   CREATE SEQUENCE public.situacao_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 &   DROP SEQUENCE public.situacao_id_seq;
       public       postgres    false    3    186            k           0    0    situacao_id_seq    SEQUENCE OWNED BY     C   ALTER SEQUENCE public.situacao_id_seq OWNED BY public.situacao.id;
            public       postgres    false    185            ?            1259    24578    usuario    TABLE     ?   CREATE TABLE public.usuario (
    id integer NOT NULL,
    email character varying(80) NOT NULL,
    senha character varying(50)
);
    DROP TABLE public.usuario;
       public         postgres    false    3            ?            1259    24576    usuario_id_seq    SEQUENCE     w   CREATE SEQUENCE public.usuario_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 %   DROP SEQUENCE public.usuario_id_seq;
       public       postgres    false    190    3            l           0    0    usuario_id_seq    SEQUENCE OWNED BY     A   ALTER SEQUENCE public.usuario_id_seq OWNED BY public.usuario.id;
            public       postgres    false    189            ?           2604    16443 
   produto id    DEFAULT     h   ALTER TABLE ONLY public.produto ALTER COLUMN id SET DEFAULT nextval('public.produto_id_seq'::regclass);
 9   ALTER TABLE public.produto ALTER COLUMN id DROP DEFAULT;
       public       postgres    false    188    187    188            ?           2604    16437    situacao id    DEFAULT     j   ALTER TABLE ONLY public.situacao ALTER COLUMN id SET DEFAULT nextval('public.situacao_id_seq'::regclass);
 :   ALTER TABLE public.situacao ALTER COLUMN id DROP DEFAULT;
       public       postgres    false    185    186    186            ?           2604    24581 
   usuario id    DEFAULT     h   ALTER TABLE ONLY public.usuario ALTER COLUMN id SET DEFAULT nextval('public.usuario_id_seq'::regclass);
 9   ALTER TABLE public.usuario ALTER COLUMN id DROP DEFAULT;
       public       postgres    false    189    190    190            _          0    16440    produto 
   TABLE DATA               F   COPY public.produto (id, descricao, quantidade, situacao) FROM stdin;
    public       postgres    false    188   ?       m           0    0    produto_id_seq    SEQUENCE SET     =   SELECT pg_catalog.setval('public.produto_id_seq', 41, true);
            public       postgres    false    187            ]          0    16434    situacao 
   TABLE DATA               1   COPY public.situacao (id, descricao) FROM stdin;
    public       postgres    false    186   ?       n           0    0    situacao_id_seq    SEQUENCE SET     =   SELECT pg_catalog.setval('public.situacao_id_seq', 3, true);
            public       postgres    false    185            a          0    24578    usuario 
   TABLE DATA               3   COPY public.usuario (id, email, senha) FROM stdin;
    public       postgres    false    190          o           0    0    usuario_id_seq    SEQUENCE SET     =   SELECT pg_catalog.setval('public.usuario_id_seq', 1, false);
            public       postgres    false    189            ?           2606    16445    produto produto_pkey 
   CONSTRAINT     R   ALTER TABLE ONLY public.produto
    ADD CONSTRAINT produto_pkey PRIMARY KEY (id);
 >   ALTER TABLE ONLY public.produto DROP CONSTRAINT produto_pkey;
       public         postgres    false    188    188            ?           2606    16447    situacao situacao_id_pk 
   CONSTRAINT     U   ALTER TABLE ONLY public.situacao
    ADD CONSTRAINT situacao_id_pk PRIMARY KEY (id);
 A   ALTER TABLE ONLY public.situacao DROP CONSTRAINT situacao_id_pk;
       public         postgres    false    186    186            ?           2606    24583    usuario usuario_pkey 
   CONSTRAINT     U   ALTER TABLE ONLY public.usuario
    ADD CONSTRAINT usuario_pkey PRIMARY KEY (email);
 >   ALTER TABLE ONLY public.usuario DROP CONSTRAINT usuario_pkey;
       public         postgres    false    190    190            ?           2606    16448    produto id_situacao_fk    FK CONSTRAINT     y   ALTER TABLE ONLY public.produto
    ADD CONSTRAINT id_situacao_fk FOREIGN KEY (situacao) REFERENCES public.situacao(id);
 @   ALTER TABLE ONLY public.produto DROP CONSTRAINT id_situacao_fk;
       public       postgres    false    186    2017    188            _   6   x?3??????,?/RHO?M-?44?4?2?,IM?ILɇ*qpq??qqq zD      ]      x?3?L,?,??2??̃?b???? RaO      a      x?????? ? ?     