PGDMP                         s            notify_danger    9.4.5    9.4.5     �           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                       false            �           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                       false            �           1262    16393    notify_danger    DATABASE     �   CREATE DATABASE notify_danger WITH TEMPLATE = template0 ENCODING = 'UTF8' LC_COLLATE = 'Polish_Poland.1250' LC_CTYPE = 'Polish_Poland.1250';
    DROP DATABASE notify_danger;
             postgres    false                        2615    2200    public    SCHEMA        CREATE SCHEMA public;
    DROP SCHEMA public;
             postgres    false            �           0    0    SCHEMA public    COMMENT     6   COMMENT ON SCHEMA public IS 'standard public schema';
                  postgres    false    5            �           0    0    public    ACL     �   REVOKE ALL ON SCHEMA public FROM PUBLIC;
REVOKE ALL ON SCHEMA public FROM postgres;
GRANT ALL ON SCHEMA public TO postgres;
GRANT ALL ON SCHEMA public TO PUBLIC;
                  postgres    false    5            �            3079    11855    plpgsql 	   EXTENSION     ?   CREATE EXTENSION IF NOT EXISTS plpgsql WITH SCHEMA pg_catalog;
    DROP EXTENSION plpgsql;
                  false            �           0    0    EXTENSION plpgsql    COMMENT     @   COMMENT ON EXTENSION plpgsql IS 'PL/pgSQL procedural language';
                       false    173            �            1259    16394    dangerous_situations    TABLE     �   CREATE TABLE dangerous_situations (
    id integer NOT NULL,
    acc_type text NOT NULL,
    acc_location text NOT NULL,
    acc_date timestamp(6) without time zone NOT NULL,
    acc_descr text
);
 (   DROP TABLE public.dangerous_situations;
       public         postgres    false    5            �          0    16394    dangerous_situations 
   TABLE DATA               X   COPY dangerous_situations (id, acc_type, acc_location, acc_date, acc_descr) FROM stdin;
    public       postgres    false    172   X
       Y           2606    16401    dangerous_situations_pkey 
   CONSTRAINT     e   ALTER TABLE ONLY dangerous_situations
    ADD CONSTRAINT dangerous_situations_pkey PRIMARY KEY (id);
 X   ALTER TABLE ONLY public.dangerous_situations DROP CONSTRAINT dangerous_situations_pkey;
       public         postgres    false    172    172            �      x������ � �     