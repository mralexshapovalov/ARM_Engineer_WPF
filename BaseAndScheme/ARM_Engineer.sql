PGDMP      ;            	    {            ARM_Engineer    16.0    16.0 V    (           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            )           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            *           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            +           1262    16762    ARM_Engineer    DATABASE     �   CREATE DATABASE "ARM_Engineer" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'Russian_Russia.1251';
    DROP DATABASE "ARM_Engineer";
                postgres    false            �            1259    16763    Approval_status    TABLE     h   CREATE TABLE public."Approval_status" (
    id integer NOT NULL,
    name text,
    description text
);
 %   DROP TABLE public."Approval_status";
       public         heap    postgres    false            ,           0    0    TABLE "Approval_status"    COMMENT     V   COMMENT ON TABLE public."Approval_status" IS 'Статус согласования';
          public          postgres    false    215            �            1259    16768    Approval_status_ID_seq    SEQUENCE     �   ALTER TABLE public."Approval_status" ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public."Approval_status_ID_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    215            �            1259    16769    Defect_list    TABLE     f   CREATE TABLE public."Defect_list" (
    id integer NOT NULL,
    "id_Type_repair" integer NOT NULL
);
 !   DROP TABLE public."Defect_list";
       public         heap    postgres    false            �            1259    16772    Defect list_ID_seq    SEQUENCE     �   ALTER TABLE public."Defect_list" ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public."Defect list_ID_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    217            �            1259    16773    Division    TABLE     K   CREATE TABLE public."Division" (
    id integer NOT NULL,
    name text
);
    DROP TABLE public."Division";
       public         heap    postgres    false            �            1259    16778    Division_ID_seq    SEQUENCE     �   ALTER TABLE public."Division" ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public."Division_ID_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    219            �            1259    16779    Employee    TABLE     �   CREATE TABLE public."Employee" (
    id integer NOT NULL,
    service_number text,
    name text,
    date_employee date,
    date_dismissal date NOT NULL,
    id_organization integer,
    year_birth date,
    id_division integer,
    id_post integer
);
    DROP TABLE public."Employee";
       public         heap    postgres    false            -           0    0    TABLE "Employee"    COMMENT     <   COMMENT ON TABLE public."Employee" IS 'Сотрудник';
          public          postgres    false    221            �            1259    16784    Employee_ID_seq    SEQUENCE     �   ALTER TABLE public."Employee" ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public."Employee_ID_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    221            �            1259    16785    Knot    TABLE     G   CREATE TABLE public."Knot" (
    id integer NOT NULL,
    name text
);
    DROP TABLE public."Knot";
       public         heap    postgres    false            .           0    0    TABLE "Knot"    COMMENT     .   COMMENT ON TABLE public."Knot" IS 'Узел';
          public          postgres    false    223            �            1259    16790    Knot_ID_seq    SEQUENCE     �   ALTER TABLE public."Knot" ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public."Knot_ID_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    223            �            1259    16791    Material    TABLE     �   CREATE TABLE public."Material" (
    "ID" integer NOT NULL,
    "Article" text,
    "Name" text,
    "Unit_measurement" text,
    "Cost" text
);
    DROP TABLE public."Material";
       public         heap    postgres    false            �            1259    16796    Material_ID_seq    SEQUENCE     �   ALTER TABLE public."Material" ALTER COLUMN "ID" ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public."Material_ID_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    225            �            1259    16797    Organization    TABLE     S   CREATE TABLE public."Organization" (
    "ID" integer NOT NULL,
    "Name" text
);
 "   DROP TABLE public."Organization";
       public         heap    postgres    false            �            1259    16802    Organization_ID_seq    SEQUENCE     �   ALTER TABLE public."Organization" ALTER COLUMN "ID" ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public."Organization_ID_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    227            �            1259    16803    Part    TABLE     �   CREATE TABLE public."Part" (
    id integer NOT NULL,
    article text,
    name text,
    id_unit_of_measurement text NOT NULL,
    "id_Unit" text,
    "id_Knot" text
);
    DROP TABLE public."Part";
       public         heap    postgres    false            /           0    0    TABLE "Part"    COMMENT     A   COMMENT ON TABLE public."Part" IS 'Запасная часть';
          public          postgres    false    229            �            1259    16808    Part_ID_seq    SEQUENCE     �   ALTER TABLE public."Part" ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public."Part_ID_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    229            �            1259    16809    Part_defect_list    TABLE     *  CREATE TABLE public."Part_defect_list" (
    id integer NOT NULL,
    id_defect_list text NOT NULL,
    id_type_repair text,
    id_employee text,
    id_part text,
    id_material text,
    operating_time text,
    date_defect_list text,
    date_document_created text,
    numer_document text
);
 &   DROP TABLE public."Part_defect_list";
       public         heap    postgres    false            �            1259    16814    Part_defect_list_ID_seq    SEQUENCE     �   ALTER TABLE public."Part_defect_list" ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public."Part_defect_list_ID_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    231            �            1259    16815    Post    TABLE     G   CREATE TABLE public."Post" (
    id integer NOT NULL,
    name text
);
    DROP TABLE public."Post";
       public         heap    postgres    false            �            1259    16820    Post_ID_seq    SEQUENCE     �   ALTER TABLE public."Post" ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public."Post_ID_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    233            �            1259    16821    Technic    TABLE     �   CREATE TABLE public."Technic" (
    "ID" integer NOT NULL,
    "ID_Type_of_equipment" text NOT NULL,
    "Name_of_the equipment" text,
    "Inventory_number" text,
    "Factory_number" text,
    "State_number" text,
    "Year_of_release" text
);
    DROP TABLE public."Technic";
       public         heap    postgres    false            0           0    0    TABLE "Technic"    COMMENT     7   COMMENT ON TABLE public."Technic" IS 'Техника';
          public          postgres    false    235            �            1259    16826    Technic_ID_seq    SEQUENCE     �   ALTER TABLE public."Technic" ALTER COLUMN "ID" ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public."Technic_ID_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    235            �            1259    16827    Type_repair    TABLE     j   CREATE TABLE public."Type_repair" (
    "ID" integer NOT NULL,
    "Name" text,
    "Description" text
);
 !   DROP TABLE public."Type_repair";
       public         heap    postgres    false            1           0    0    TABLE "Type_repair"    COMMENT     B   COMMENT ON TABLE public."Type_repair" IS 'Вид ремонта';
          public          postgres    false    237            �            1259    16832    Type_repair_ID_seq    SEQUENCE     �   ALTER TABLE public."Type_repair" ALTER COLUMN "ID" ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public."Type_repair_ID_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    237            �            1259    16833    Uint    TABLE     K   CREATE TABLE public."Uint" (
    "ID" integer NOT NULL,
    "Name" text
);
    DROP TABLE public."Uint";
       public         heap    postgres    false            2           0    0    TABLE "Uint"    COMMENT     4   COMMENT ON TABLE public."Uint" IS 'Агрегат';
          public          postgres    false    239            �            1259    16838    Uint_ID_seq    SEQUENCE     �   ALTER TABLE public."Uint" ALTER COLUMN "ID" ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public."Uint_ID_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    239            �            1259    16839    Unit_of_measurement    TABLE     Z   CREATE TABLE public."Unit_of_measurement" (
    "ID" integer NOT NULL,
    "Name" text
);
 )   DROP TABLE public."Unit_of_measurement";
       public         heap    postgres    false            3           0    0    TABLE "Unit_of_measurement"    COMMENT     V   COMMENT ON TABLE public."Unit_of_measurement" IS 'Единица измерения';
          public          postgres    false    241            �            1259    16844    Unit_of_measurement_ID_seq    SEQUENCE     �   ALTER TABLE public."Unit_of_measurement" ALTER COLUMN "ID" ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public."Unit_of_measurement_ID_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    241            
          0    16763    Approval_status 
   TABLE DATA           B   COPY public."Approval_status" (id, name, description) FROM stdin;
    public          postgres    false    215   d^                 0    16769    Defect_list 
   TABLE DATA           =   COPY public."Defect_list" (id, "id_Type_repair") FROM stdin;
    public          postgres    false    217   _                 0    16773    Division 
   TABLE DATA           .   COPY public."Division" (id, name) FROM stdin;
    public          postgres    false    219   '_                 0    16779    Employee 
   TABLE DATA           �   COPY public."Employee" (id, service_number, name, date_employee, date_dismissal, id_organization, year_birth, id_division, id_post) FROM stdin;
    public          postgres    false    221   M`                 0    16785    Knot 
   TABLE DATA           *   COPY public."Knot" (id, name) FROM stdin;
    public          postgres    false    223   sa                 0    16791    Material 
   TABLE DATA           Y   COPY public."Material" ("ID", "Article", "Name", "Unit_measurement", "Cost") FROM stdin;
    public          postgres    false    225   �a                 0    16797    Organization 
   TABLE DATA           6   COPY public."Organization" ("ID", "Name") FROM stdin;
    public          postgres    false    227   �a                 0    16803    Part 
   TABLE DATA           a   COPY public."Part" (id, article, name, id_unit_of_measurement, "id_Unit", "id_Knot") FROM stdin;
    public          postgres    false    229   c                 0    16809    Part_defect_list 
   TABLE DATA           �   COPY public."Part_defect_list" (id, id_defect_list, id_type_repair, id_employee, id_part, id_material, operating_time, date_defect_list, date_document_created, numer_document) FROM stdin;
    public          postgres    false    231   .c                 0    16815    Post 
   TABLE DATA           *   COPY public."Post" (id, name) FROM stdin;
    public          postgres    false    233   Kc                 0    16821    Technic 
   TABLE DATA           �   COPY public."Technic" ("ID", "ID_Type_of_equipment", "Name_of_the equipment", "Inventory_number", "Factory_number", "State_number", "Year_of_release") FROM stdin;
    public          postgres    false    235   Pe                  0    16827    Type_repair 
   TABLE DATA           D   COPY public."Type_repair" ("ID", "Name", "Description") FROM stdin;
    public          postgres    false    237   �e       "          0    16833    Uint 
   TABLE DATA           .   COPY public."Uint" ("ID", "Name") FROM stdin;
    public          postgres    false    239   �f       $          0    16839    Unit_of_measurement 
   TABLE DATA           =   COPY public."Unit_of_measurement" ("ID", "Name") FROM stdin;
    public          postgres    false    241   �f       4           0    0    Approval_status_ID_seq    SEQUENCE SET     F   SELECT pg_catalog.setval('public."Approval_status_ID_seq"', 5, true);
          public          postgres    false    216            5           0    0    Defect list_ID_seq    SEQUENCE SET     B   SELECT pg_catalog.setval('public."Defect list_ID_seq"', 2, true);
          public          postgres    false    218            6           0    0    Division_ID_seq    SEQUENCE SET     @   SELECT pg_catalog.setval('public."Division_ID_seq"', 15, true);
          public          postgres    false    220            7           0    0    Employee_ID_seq    SEQUENCE SET     @   SELECT pg_catalog.setval('public."Employee_ID_seq"', 13, true);
          public          postgres    false    222            8           0    0    Knot_ID_seq    SEQUENCE SET     <   SELECT pg_catalog.setval('public."Knot_ID_seq"', 1, false);
          public          postgres    false    224            9           0    0    Material_ID_seq    SEQUENCE SET     @   SELECT pg_catalog.setval('public."Material_ID_seq"', 1, false);
          public          postgres    false    226            :           0    0    Organization_ID_seq    SEQUENCE SET     D   SELECT pg_catalog.setval('public."Organization_ID_seq"', 21, true);
          public          postgres    false    228            ;           0    0    Part_ID_seq    SEQUENCE SET     <   SELECT pg_catalog.setval('public."Part_ID_seq"', 1, false);
          public          postgres    false    230            <           0    0    Part_defect_list_ID_seq    SEQUENCE SET     H   SELECT pg_catalog.setval('public."Part_defect_list_ID_seq"', 1, false);
          public          postgres    false    232            =           0    0    Post_ID_seq    SEQUENCE SET     <   SELECT pg_catalog.setval('public."Post_ID_seq"', 25, true);
          public          postgres    false    234            >           0    0    Technic_ID_seq    SEQUENCE SET     >   SELECT pg_catalog.setval('public."Technic_ID_seq"', 1, true);
          public          postgres    false    236            ?           0    0    Type_repair_ID_seq    SEQUENCE SET     B   SELECT pg_catalog.setval('public."Type_repair_ID_seq"', 4, true);
          public          postgres    false    238            @           0    0    Uint_ID_seq    SEQUENCE SET     <   SELECT pg_catalog.setval('public."Uint_ID_seq"', 1, false);
          public          postgres    false    240            A           0    0    Unit_of_measurement_ID_seq    SEQUENCE SET     J   SELECT pg_catalog.setval('public."Unit_of_measurement_ID_seq"', 3, true);
          public          postgres    false    242            \           2606    16846 $   Approval_status Approval_status_pkey 
   CONSTRAINT     f   ALTER TABLE ONLY public."Approval_status"
    ADD CONSTRAINT "Approval_status_pkey" PRIMARY KEY (id);
 R   ALTER TABLE ONLY public."Approval_status" DROP CONSTRAINT "Approval_status_pkey";
       public            postgres    false    215            ^           2606    16848    Defect_list Defect list_pkey 
   CONSTRAINT     l   ALTER TABLE ONLY public."Defect_list"
    ADD CONSTRAINT "Defect list_pkey" PRIMARY KEY ("id_Type_repair");
 J   ALTER TABLE ONLY public."Defect_list" DROP CONSTRAINT "Defect list_pkey";
       public            postgres    false    217            `           2606    16850    Division Division_pkey 
   CONSTRAINT     X   ALTER TABLE ONLY public."Division"
    ADD CONSTRAINT "Division_pkey" PRIMARY KEY (id);
 D   ALTER TABLE ONLY public."Division" DROP CONSTRAINT "Division_pkey";
       public            postgres    false    219            b           2606    16852    Employee Employee_pkey 
   CONSTRAINT     X   ALTER TABLE ONLY public."Employee"
    ADD CONSTRAINT "Employee_pkey" PRIMARY KEY (id);
 D   ALTER TABLE ONLY public."Employee" DROP CONSTRAINT "Employee_pkey";
       public            postgres    false    221            d           2606    16854    Knot Knot_pkey 
   CONSTRAINT     P   ALTER TABLE ONLY public."Knot"
    ADD CONSTRAINT "Knot_pkey" PRIMARY KEY (id);
 <   ALTER TABLE ONLY public."Knot" DROP CONSTRAINT "Knot_pkey";
       public            postgres    false    223            f           2606    16856    Material Material_pkey 
   CONSTRAINT     Z   ALTER TABLE ONLY public."Material"
    ADD CONSTRAINT "Material_pkey" PRIMARY KEY ("ID");
 D   ALTER TABLE ONLY public."Material" DROP CONSTRAINT "Material_pkey";
       public            postgres    false    225            h           2606    16858    Organization Organization_pkey 
   CONSTRAINT     b   ALTER TABLE ONLY public."Organization"
    ADD CONSTRAINT "Organization_pkey" PRIMARY KEY ("ID");
 L   ALTER TABLE ONLY public."Organization" DROP CONSTRAINT "Organization_pkey";
       public            postgres    false    227            l           2606    16860 &   Part_defect_list Part_defect_list_pkey 
   CONSTRAINT     t   ALTER TABLE ONLY public."Part_defect_list"
    ADD CONSTRAINT "Part_defect_list_pkey" PRIMARY KEY (id_defect_list);
 T   ALTER TABLE ONLY public."Part_defect_list" DROP CONSTRAINT "Part_defect_list_pkey";
       public            postgres    false    231            j           2606    16862    Part Part_pkey 
   CONSTRAINT     d   ALTER TABLE ONLY public."Part"
    ADD CONSTRAINT "Part_pkey" PRIMARY KEY (id_unit_of_measurement);
 <   ALTER TABLE ONLY public."Part" DROP CONSTRAINT "Part_pkey";
       public            postgres    false    229            n           2606    16864    Post Post_pkey 
   CONSTRAINT     P   ALTER TABLE ONLY public."Post"
    ADD CONSTRAINT "Post_pkey" PRIMARY KEY (id);
 <   ALTER TABLE ONLY public."Post" DROP CONSTRAINT "Post_pkey";
       public            postgres    false    233            p           2606    16866    Technic Technic_pkey 
   CONSTRAINT     j   ALTER TABLE ONLY public."Technic"
    ADD CONSTRAINT "Technic_pkey" PRIMARY KEY ("ID_Type_of_equipment");
 B   ALTER TABLE ONLY public."Technic" DROP CONSTRAINT "Technic_pkey";
       public            postgres    false    235            r           2606    16868    Type_repair Type_repair_pkey 
   CONSTRAINT     `   ALTER TABLE ONLY public."Type_repair"
    ADD CONSTRAINT "Type_repair_pkey" PRIMARY KEY ("ID");
 J   ALTER TABLE ONLY public."Type_repair" DROP CONSTRAINT "Type_repair_pkey";
       public            postgres    false    237            t           2606    16870    Uint Uint_pkey 
   CONSTRAINT     R   ALTER TABLE ONLY public."Uint"
    ADD CONSTRAINT "Uint_pkey" PRIMARY KEY ("ID");
 <   ALTER TABLE ONLY public."Uint" DROP CONSTRAINT "Uint_pkey";
       public            postgres    false    239            v           2606    16872 ,   Unit_of_measurement Unit_of_measurement_pkey 
   CONSTRAINT     p   ALTER TABLE ONLY public."Unit_of_measurement"
    ADD CONSTRAINT "Unit_of_measurement_pkey" PRIMARY KEY ("ID");
 Z   ALTER TABLE ONLY public."Unit_of_measurement" DROP CONSTRAINT "Unit_of_measurement_pkey";
       public            postgres    false    241            w           2606    16873 +   Defect_list Defect_list_ID_Type_repair_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public."Defect_list"
    ADD CONSTRAINT "Defect_list_ID_Type_repair_fkey" FOREIGN KEY ("id_Type_repair") REFERENCES public."Type_repair"("ID") NOT VALID;
 Y   ALTER TABLE ONLY public."Defect_list" DROP CONSTRAINT "Defect_list_ID_Type_repair_fkey";
       public          postgres    false    217    237    4722            x           2606    16878 "   Employee Employee_ID_Division_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public."Employee"
    ADD CONSTRAINT "Employee_ID_Division_fkey" FOREIGN KEY (id_division) REFERENCES public."Division"(id) NOT VALID;
 P   ALTER TABLE ONLY public."Employee" DROP CONSTRAINT "Employee_ID_Division_fkey";
       public          postgres    false    219    4704    221            y           2606    16883 &   Employee Employee_ID_Organization_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public."Employee"
    ADD CONSTRAINT "Employee_ID_Organization_fkey" FOREIGN KEY (id_organization) REFERENCES public."Organization"("ID") NOT VALID;
 T   ALTER TABLE ONLY public."Employee" DROP CONSTRAINT "Employee_ID_Organization_fkey";
       public          postgres    false    221    4712    227            z           2606    16888    Employee Employee_ID_Post_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public."Employee"
    ADD CONSTRAINT "Employee_ID_Post_fkey" FOREIGN KEY (id_post) REFERENCES public."Post"(id) NOT VALID;
 L   ALTER TABLE ONLY public."Employee" DROP CONSTRAINT "Employee_ID_Post_fkey";
       public          postgres    false    221    233    4718            
   �   x�u�K
�PE�7�p��}|�&\A7��c�(8rZ��R�k�ّ�	m!9�@�G��a)a�!~��S�C��� ���߬���Ɋ=��x��z���:�76�m���I�Z�enp�[b�'�5�`�G�ܲ�n��RD~CF��            x�3�4����� k            x��P[N�@��9�^���-��p��	�����&i��W�����P���7�xl����f<�Hg�W��^��Pj�	z���@)�W^:D,�Ԛs�H���3��O���_oВ;쥁��Y�[l<��d���=m��2ya���r�p��ܤP�0IRK�������]����G�-� ��B±��5[��`�̚��~3z����h�_n���ޭ�3\%̓5���IՐl/ub�K+lWk��uL����^*D�Dc�>��,��HD� �#y�           x���Mj�0�ףS8pь��%C���!P�礪���%0����)��qC�=~�>�b���rE��;�ѓ�u�t��f�n�Q(^$����� ;�`!�t�l�M�}i��F�T��9b�ɐ�O9���s�w���4vx�_��ҽ񝬕;t���e,�`���a(�[y� ��
���N��M?=L� �8bO_�S�A���e���,�T�1��+oz �?��ϻ3 �QK6��;6��7�n[����&�>��B-'�E�	�^>8�~ ���            x������ � �            x������ � �         T  x��R�J�@|v�b�WA��Z�?&���B���^|�����/��#�l�&B	$�s��sf�#<�c�r�V(�I�Q��i걯�16�آ��]�=
�A��ila�5v��wi	W;δ"�+
2�IG��-frG�@~�&AQ�-�����`���֙v�0�Z�9������)��U��񦁀�_]҈����u���4��h+5IbˀE9E�?М���uk�46k�iT����cf��h�F=;Uђ�V웖�r���Og��H���5O�vl�Z��c��[}g��cª�nƫ��F=���;m�H�Z�o�5�Ğ�NE	�`|י�c�/Q��            x������ � �            x������ � �         �  x��T[nA��>�\ �g��K���C$r�D�e��[Z�k���jn����EV>AOMuUw-��<��gs�>c�Sl�������5P�����+�?j��L�_�+O�3,Y�򙡖�s��b��\=s�s����*�����)���;��#C���\8|'�-엊>��cHS�8���5Mz��'~ɥ�W��4K�C����\�͛��IY�Ѱ?���y�(�|V�D'dRw�i�R3y��I��n&.���>i���Х�YH8�x|����ٷ���1�J��)���ZJ<ġ�P}�����2���SD)�a�?�ɳ���퐤6۹�(�N~�M�9#p,��N]k|���\S�*�� �?��¶��EMڷu,��w`.[��ӎ����D'|�p4���q�]��~������x��	��JX��\әd'���h(�ti�C{�6�p�]�^5�̨*�,�w��o!Y��),�ig�-@��y�Ξ�ң?'�y�RD� ��5�         \   x�3�0���[/l���bÅ}�y;.���qtqT02421�443000�3�q4014126r224�4��0T�0��3CN##c�=... `�          �   x���]n�@������J��Ð�
$���,)[B6W߈��JE�G}Yٻ3��=+��Q���c�-za�pAf[��.huˋ�M���Vڔ,*^u�5�'�t��Ed�qD�.���"�&�{Z#�ٲ�x~{uLlnx�٦���.�J���Nd3{/��Ur���
�G"u�Q���X��sHf��g��q�5�
o4�NM��?U��P���T�䢿G�;�tvG�o�8x)��;2����}C��˓�	���1\�      "      x������ � �      $   !   x�3估��f.#�{��9/v\l����� |��     