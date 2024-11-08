PGDMP  #    &            
    |            uts_mvc    16.2    16.2     �           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            �           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            �           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            �           1262    27344    uts_mvc    DATABASE     ~   CREATE DATABASE uts_mvc WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'English_Indonesia.1252';
    DROP DATABASE uts_mvc;
                postgres    false            �            1259    27346    buku    TABLE     �   CREATE TABLE public.buku (
    id integer NOT NULL,
    judul character varying(100) NOT NULL,
    pengarang character varying(100) NOT NULL,
    tahun_terbit character varying(10) NOT NULL,
    kategori character varying(40)
);
    DROP TABLE public.buku;
       public         heap    postgres    false            �            1259    27345    buku_id_seq    SEQUENCE     �   CREATE SEQUENCE public.buku_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 "   DROP SEQUENCE public.buku_id_seq;
       public          postgres    false    216            �           0    0    buku_id_seq    SEQUENCE OWNED BY     ;   ALTER SEQUENCE public.buku_id_seq OWNED BY public.buku.id;
          public          postgres    false    215            �            1259    27353    pengguna    TABLE     �   CREATE TABLE public.pengguna (
    id integer NOT NULL,
    nama character varying(100) NOT NULL,
    username character varying(20) NOT NULL,
    password character varying(20) NOT NULL
);
    DROP TABLE public.pengguna;
       public         heap    postgres    false            �            1259    27352    pengguna_id_seq    SEQUENCE     �   CREATE SEQUENCE public.pengguna_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 &   DROP SEQUENCE public.pengguna_id_seq;
       public          postgres    false    218            �           0    0    pengguna_id_seq    SEQUENCE OWNED BY     C   ALTER SEQUENCE public.pengguna_id_seq OWNED BY public.pengguna.id;
          public          postgres    false    217            U           2604    27349    buku id    DEFAULT     b   ALTER TABLE ONLY public.buku ALTER COLUMN id SET DEFAULT nextval('public.buku_id_seq'::regclass);
 6   ALTER TABLE public.buku ALTER COLUMN id DROP DEFAULT;
       public          postgres    false    215    216    216            V           2604    27356    pengguna id    DEFAULT     j   ALTER TABLE ONLY public.pengguna ALTER COLUMN id SET DEFAULT nextval('public.pengguna_id_seq'::regclass);
 :   ALTER TABLE public.pengguna ALTER COLUMN id DROP DEFAULT;
       public          postgres    false    217    218    218            �          0    27346    buku 
   TABLE DATA           L   COPY public.buku (id, judul, pengarang, tahun_terbit, kategori) FROM stdin;
    public          postgres    false    216   *       �          0    27353    pengguna 
   TABLE DATA           @   COPY public.pengguna (id, nama, username, password) FROM stdin;
    public          postgres    false    218   r       �           0    0    buku_id_seq    SEQUENCE SET     9   SELECT pg_catalog.setval('public.buku_id_seq', 2, true);
          public          postgres    false    215            �           0    0    pengguna_id_seq    SEQUENCE SET     =   SELECT pg_catalog.setval('public.pengguna_id_seq', 2, true);
          public          postgres    false    217            X           2606    27351    buku buku_pkey 
   CONSTRAINT     L   ALTER TABLE ONLY public.buku
    ADD CONSTRAINT buku_pkey PRIMARY KEY (id);
 8   ALTER TABLE ONLY public.buku DROP CONSTRAINT buku_pkey;
       public            postgres    false    216            Z           2606    27358    pengguna pengguna_pkey 
   CONSTRAINT     T   ALTER TABLE ONLY public.pengguna
    ADD CONSTRAINT pengguna_pkey PRIMARY KEY (id);
 @   ALTER TABLE ONLY public.pengguna DROP CONSTRAINT pengguna_pkey;
       public            postgres    false    218            �   8   x�3�����L�tt�420�����Sp��.��2�t�,��N�trJ I��qqq ���      �   +   x�3���L�LL���3�462�2�L���qs��qqq �)	�     