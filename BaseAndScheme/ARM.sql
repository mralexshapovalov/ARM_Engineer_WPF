PGDMP                  	    {            ARM_Engineer    16rc1    16rc1 V    ^           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            _           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            `           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            a           1262    24576    ARM_Engineer    DATABASE     �   CREATE DATABASE "ARM_Engineer" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'English_United States.1251';
    DROP DATABASE "ARM_Engineer";
                postgres    false            �            1259    24577    Approval_status    TABLE     n   CREATE TABLE public."Approval_status" (
    "ID" integer NOT NULL,
    "Name" text,
    "Description" text
);
 %   DROP TABLE public."Approval_status";
       public         heap    postgres    false            b           0    0    TABLE "Approval_status"    COMMENT     V   COMMENT ON TABLE public."Approval_status" IS 'Статус согласования';
          public          postgres    false    215            �            1259    24582    Approval_status_ID_seq    SEQUENCE     �   ALTER TABLE public."Approval_status" ALTER COLUMN "ID" ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public."Approval_status_ID_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    215            �            1259    24583    Defect_list    TABLE     h   CREATE TABLE public."Defect_list" (
    "ID" integer NOT NULL,
    "ID_Type_repair" integer NOT NULL
);
 !   DROP TABLE public."Defect_list";
       public         heap    postgres    false            �            1259    24586    Defect list_ID_seq    SEQUENCE     �   ALTER TABLE public."Defect_list" ALTER COLUMN "ID" ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public."Defect list_ID_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    217            �            1259    24682    Division    TABLE     O   CREATE TABLE public."Division" (
    "ID" integer NOT NULL,
    "Name" text
);
    DROP TABLE public."Division";
       public         heap    postgres    false            �            1259    24694    Division_ID_seq    SEQUENCE     �   ALTER TABLE public."Division" ALTER COLUMN "ID" ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public."Division_ID_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    239            �            1259    24587    Employee    TABLE       CREATE TABLE public."Employee" (
    "ID" integer NOT NULL,
    "Service_number" text,
    "Name" text,
    "Date_Employee" date,
    "Date_dismissal" date,
    "ID_Organization" integer,
    "Year_birth" date,
    "ID_Division" integer,
    "ID_Post" integer
);
    DROP TABLE public."Employee";
       public         heap    postgres    false            c           0    0    TABLE "Employee"    COMMENT     <   COMMENT ON TABLE public."Employee" IS 'Сотрудник';
          public          postgres    false    219            �            1259    24592    Employee_ID_seq    SEQUENCE     �   ALTER TABLE public."Employee" ALTER COLUMN "ID" ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public."Employee_ID_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    219            �            1259    24593    Knot    TABLE     K   CREATE TABLE public."Knot" (
    "ID" integer NOT NULL,
    "Name" text
);
    DROP TABLE public."Knot";
       public         heap    postgres    false            d           0    0    TABLE "Knot"    COMMENT     .   COMMENT ON TABLE public."Knot" IS 'Узел';
          public          postgres    false    221            �            1259    24598    Knot_ID_seq    SEQUENCE     �   ALTER TABLE public."Knot" ALTER COLUMN "ID" ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public."Knot_ID_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    221            �            1259    24599    Material    TABLE     �   CREATE TABLE public."Material" (
    "ID" integer NOT NULL,
    "Article" text,
    "Name" text,
    "Unit_measurement" text,
    "Cost" text
);
    DROP TABLE public."Material";
       public         heap    postgres    false            �            1259    24604    Material_ID_seq    SEQUENCE     �   ALTER TABLE public."Material" ALTER COLUMN "ID" ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public."Material_ID_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    223            �            1259    24605    Organization    TABLE     S   CREATE TABLE public."Organization" (
    "ID" integer NOT NULL,
    "Name" text
);
 "   DROP TABLE public."Organization";
       public         heap    postgres    false            �            1259    24610    Organization_ID_seq    SEQUENCE     �   ALTER TABLE public."Organization" ALTER COLUMN "ID" ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public."Organization_ID_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    225            �            1259    24611    Part    TABLE     �   CREATE TABLE public."Part" (
    "ID" integer NOT NULL,
    "Article" text,
    "Name" text,
    "ID_Unit_of_measurement" text NOT NULL,
    "ID_Unit" text,
    "ID_Knot" text
);
    DROP TABLE public."Part";
       public         heap    postgres    false            e           0    0    TABLE "Part"    COMMENT     A   COMMENT ON TABLE public."Part" IS 'Запасная часть';
          public          postgres    false    227            �            1259    24616    Part_ID_seq    SEQUENCE     �   ALTER TABLE public."Part" ALTER COLUMN "ID" ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public."Part_ID_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    227            �            1259    24617    Part_defect_list    TABLE     >  CREATE TABLE public."Part_defect_list" (
    "ID" integer NOT NULL,
    "ID_Defect_list" text NOT NULL,
    "ID_Type_repair" text,
    "ID_Employee" text,
    "ID_Part" text,
    "ID_Material" text,
    "Operating_time" text,
    "Date_defect_list" text,
    "Date_document_created" text,
    "Numer_document" text
);
 &   DROP TABLE public."Part_defect_list";
       public         heap    postgres    false            �            1259    24622    Part_defect_list_ID_seq    SEQUENCE     �   ALTER TABLE public."Part_defect_list" ALTER COLUMN "ID" ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public."Part_defect_list_ID_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    229            �            1259    24695    Post    TABLE     K   CREATE TABLE public."Post" (
    "ID" integer NOT NULL,
    "Name" text
);
    DROP TABLE public."Post";
       public         heap    postgres    false            �            1259    24707    Post_ID_seq    SEQUENCE     �   ALTER TABLE public."Post" ALTER COLUMN "ID" ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public."Post_ID_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    241            �            1259    24623    Technic    TABLE     �   CREATE TABLE public."Technic" (
    "ID" integer NOT NULL,
    "ID_Type_of_equipment" text NOT NULL,
    "Name_of_the equipment" text,
    "Inventory_number" text,
    "Factory_number" text,
    "State_number" text,
    "Year_of_release" text
);
    DROP TABLE public."Technic";
       public         heap    postgres    false            f           0    0    TABLE "Technic"    COMMENT     7   COMMENT ON TABLE public."Technic" IS 'Техника';
          public          postgres    false    231            �            1259    24628    Technic_ID_seq    SEQUENCE     �   ALTER TABLE public."Technic" ALTER COLUMN "ID" ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public."Technic_ID_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    231            �            1259    24629    Type_repair    TABLE     j   CREATE TABLE public."Type_repair" (
    "ID" integer NOT NULL,
    "Name" text,
    "Description" text
);
 !   DROP TABLE public."Type_repair";
       public         heap    postgres    false            g           0    0    TABLE "Type_repair"    COMMENT     B   COMMENT ON TABLE public."Type_repair" IS 'Вид ремонта';
          public          postgres    false    233            �            1259    24634    Type_repair_ID_seq    SEQUENCE     �   ALTER TABLE public."Type_repair" ALTER COLUMN "ID" ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public."Type_repair_ID_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    233            �            1259    24635    Uint    TABLE     K   CREATE TABLE public."Uint" (
    "ID" integer NOT NULL,
    "Name" text
);
    DROP TABLE public."Uint";
       public         heap    postgres    false            h           0    0    TABLE "Uint"    COMMENT     4   COMMENT ON TABLE public."Uint" IS 'Агрегат';
          public          postgres    false    235            �            1259    24640    Uint_ID_seq    SEQUENCE     �   ALTER TABLE public."Uint" ALTER COLUMN "ID" ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public."Uint_ID_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    235            �            1259    24641    Unit_of_measurement    TABLE     Z   CREATE TABLE public."Unit_of_measurement" (
    "ID" integer NOT NULL,
    "Name" text
);
 )   DROP TABLE public."Unit_of_measurement";
       public         heap    postgres    false            i           0    0    TABLE "Unit_of_measurement"    COMMENT     V   COMMENT ON TABLE public."Unit_of_measurement" IS 'Единица измерения';
          public          postgres    false    237            �            1259    24646    Unit_of_measurement_ID_seq    SEQUENCE     �   ALTER TABLE public."Unit_of_measurement" ALTER COLUMN "ID" ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public."Unit_of_measurement_ID_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    237            @          0    24577    Approval_status 
   TABLE DATA           H   COPY public."Approval_status" ("ID", "Name", "Description") FROM stdin;
    public          postgres    false    215   _       B          0    24583    Defect_list 
   TABLE DATA           ?   COPY public."Defect_list" ("ID", "ID_Type_repair") FROM stdin;
    public          postgres    false    217   �_       X          0    24682    Division 
   TABLE DATA           2   COPY public."Division" ("ID", "Name") FROM stdin;
    public          postgres    false    239   �_       D          0    24587    Employee 
   TABLE DATA           �   COPY public."Employee" ("ID", "Service_number", "Name", "Date_Employee", "Date_dismissal", "ID_Organization", "Year_birth", "ID_Division", "ID_Post") FROM stdin;
    public          postgres    false    219   4`       F          0    24593    Knot 
   TABLE DATA           .   COPY public."Knot" ("ID", "Name") FROM stdin;
    public          postgres    false    221   �`       H          0    24599    Material 
   TABLE DATA           Y   COPY public."Material" ("ID", "Article", "Name", "Unit_measurement", "Cost") FROM stdin;
    public          postgres    false    223   a       J          0    24605    Organization 
   TABLE DATA           6   COPY public."Organization" ("ID", "Name") FROM stdin;
    public          postgres    false    225   9a       L          0    24611    Part 
   TABLE DATA           i   COPY public."Part" ("ID", "Article", "Name", "ID_Unit_of_measurement", "ID_Unit", "ID_Knot") FROM stdin;
    public          postgres    false    227   ua       N          0    24617    Part_defect_list 
   TABLE DATA           �   COPY public."Part_defect_list" ("ID", "ID_Defect_list", "ID_Type_repair", "ID_Employee", "ID_Part", "ID_Material", "Operating_time", "Date_defect_list", "Date_document_created", "Numer_document") FROM stdin;
    public          postgres    false    229   �a       Z          0    24695    Post 
   TABLE DATA           .   COPY public."Post" ("ID", "Name") FROM stdin;
    public          postgres    false    241   �a       P          0    24623    Technic 
   TABLE DATA           �   COPY public."Technic" ("ID", "ID_Type_of_equipment", "Name_of_the equipment", "Inventory_number", "Factory_number", "State_number", "Year_of_release") FROM stdin;
    public          postgres    false    231   �a       R          0    24629    Type_repair 
   TABLE DATA           D   COPY public."Type_repair" ("ID", "Name", "Description") FROM stdin;
    public          postgres    false    233   _b       T          0    24635    Uint 
   TABLE DATA           .   COPY public."Uint" ("ID", "Name") FROM stdin;
    public          postgres    false    235   mc       V          0    24641    Unit_of_measurement 
   TABLE DATA           =   COPY public."Unit_of_measurement" ("ID", "Name") FROM stdin;
    public          postgres    false    237   �c       j           0    0    Approval_status_ID_seq    SEQUENCE SET     F   SELECT pg_catalog.setval('public."Approval_status_ID_seq"', 5, true);
          public          postgres    false    216            k           0    0    Defect list_ID_seq    SEQUENCE SET     B   SELECT pg_catalog.setval('public."Defect list_ID_seq"', 2, true);
          public          postgres    false    218            l           0    0    Division_ID_seq    SEQUENCE SET     ?   SELECT pg_catalog.setval('public."Division_ID_seq"', 4, true);
          public          postgres    false    240            m           0    0    Employee_ID_seq    SEQUENCE SET     ?   SELECT pg_catalog.setval('public."Employee_ID_seq"', 7, true);
          public          postgres    false    220            n           0    0    Knot_ID_seq    SEQUENCE SET     <   SELECT pg_catalog.setval('public."Knot_ID_seq"', 1, false);
          public          postgres    false    222            o           0    0    Material_ID_seq    SEQUENCE SET     @   SELECT pg_catalog.setval('public."Material_ID_seq"', 1, false);
          public          postgres    false    224            p           0    0    Organization_ID_seq    SEQUENCE SET     C   SELECT pg_catalog.setval('public."Organization_ID_seq"', 2, true);
          public          postgres    false    226            q           0    0    Part_ID_seq    SEQUENCE SET     <   SELECT pg_catalog.setval('public."Part_ID_seq"', 1, false);
          public          postgres    false    228            r           0    0    Part_defect_list_ID_seq    SEQUENCE SET     H   SELECT pg_catalog.setval('public."Part_defect_list_ID_seq"', 1, false);
          public          postgres    false    230            s           0    0    Post_ID_seq    SEQUENCE SET     ;   SELECT pg_catalog.setval('public."Post_ID_seq"', 2, true);
          public          postgres    false    242            t           0    0    Technic_ID_seq    SEQUENCE SET     >   SELECT pg_catalog.setval('public."Technic_ID_seq"', 1, true);
          public          postgres    false    232            u           0    0    Type_repair_ID_seq    SEQUENCE SET     B   SELECT pg_catalog.setval('public."Type_repair_ID_seq"', 4, true);
          public          postgres    false    234            v           0    0    Uint_ID_seq    SEQUENCE SET     <   SELECT pg_catalog.setval('public."Uint_ID_seq"', 1, false);
          public          postgres    false    236            w           0    0    Unit_of_measurement_ID_seq    SEQUENCE SET     J   SELECT pg_catalog.setval('public."Unit_of_measurement_ID_seq"', 3, true);
          public          postgres    false    238            �           2606    24648 $   Approval_status Approval_status_pkey 
   CONSTRAINT     h   ALTER TABLE ONLY public."Approval_status"
    ADD CONSTRAINT "Approval_status_pkey" PRIMARY KEY ("ID");
 R   ALTER TABLE ONLY public."Approval_status" DROP CONSTRAINT "Approval_status_pkey";
       public            postgres    false    215            �           2606    24650    Defect_list Defect list_pkey 
   CONSTRAINT     l   ALTER TABLE ONLY public."Defect_list"
    ADD CONSTRAINT "Defect list_pkey" PRIMARY KEY ("ID_Type_repair");
 J   ALTER TABLE ONLY public."Defect_list" DROP CONSTRAINT "Defect list_pkey";
       public            postgres    false    217            �           2606    24688    Division Division_pkey 
   CONSTRAINT     Z   ALTER TABLE ONLY public."Division"
    ADD CONSTRAINT "Division_pkey" PRIMARY KEY ("ID");
 D   ALTER TABLE ONLY public."Division" DROP CONSTRAINT "Division_pkey";
       public            postgres    false    239            �           2606    24652    Employee Employee_pkey 
   CONSTRAINT     Z   ALTER TABLE ONLY public."Employee"
    ADD CONSTRAINT "Employee_pkey" PRIMARY KEY ("ID");
 D   ALTER TABLE ONLY public."Employee" DROP CONSTRAINT "Employee_pkey";
       public            postgres    false    219            �           2606    24654    Knot Knot_pkey 
   CONSTRAINT     R   ALTER TABLE ONLY public."Knot"
    ADD CONSTRAINT "Knot_pkey" PRIMARY KEY ("ID");
 <   ALTER TABLE ONLY public."Knot" DROP CONSTRAINT "Knot_pkey";
       public            postgres    false    221            �           2606    24656    Material Material_pkey 
   CONSTRAINT     Z   ALTER TABLE ONLY public."Material"
    ADD CONSTRAINT "Material_pkey" PRIMARY KEY ("ID");
 D   ALTER TABLE ONLY public."Material" DROP CONSTRAINT "Material_pkey";
       public            postgres    false    223            �           2606    24658    Organization Organization_pkey 
   CONSTRAINT     b   ALTER TABLE ONLY public."Organization"
    ADD CONSTRAINT "Organization_pkey" PRIMARY KEY ("ID");
 L   ALTER TABLE ONLY public."Organization" DROP CONSTRAINT "Organization_pkey";
       public            postgres    false    225            �           2606    24660 &   Part_defect_list Part_defect_list_pkey 
   CONSTRAINT     v   ALTER TABLE ONLY public."Part_defect_list"
    ADD CONSTRAINT "Part_defect_list_pkey" PRIMARY KEY ("ID_Defect_list");
 T   ALTER TABLE ONLY public."Part_defect_list" DROP CONSTRAINT "Part_defect_list_pkey";
       public            postgres    false    229            �           2606    24662    Part Part_pkey 
   CONSTRAINT     f   ALTER TABLE ONLY public."Part"
    ADD CONSTRAINT "Part_pkey" PRIMARY KEY ("ID_Unit_of_measurement");
 <   ALTER TABLE ONLY public."Part" DROP CONSTRAINT "Part_pkey";
       public            postgres    false    227            �           2606    24701    Post Post_pkey 
   CONSTRAINT     R   ALTER TABLE ONLY public."Post"
    ADD CONSTRAINT "Post_pkey" PRIMARY KEY ("ID");
 <   ALTER TABLE ONLY public."Post" DROP CONSTRAINT "Post_pkey";
       public            postgres    false    241            �           2606    24664    Technic Technic_pkey 
   CONSTRAINT     j   ALTER TABLE ONLY public."Technic"
    ADD CONSTRAINT "Technic_pkey" PRIMARY KEY ("ID_Type_of_equipment");
 B   ALTER TABLE ONLY public."Technic" DROP CONSTRAINT "Technic_pkey";
       public            postgres    false    231            �           2606    24666    Type_repair Type_repair_pkey 
   CONSTRAINT     `   ALTER TABLE ONLY public."Type_repair"
    ADD CONSTRAINT "Type_repair_pkey" PRIMARY KEY ("ID");
 J   ALTER TABLE ONLY public."Type_repair" DROP CONSTRAINT "Type_repair_pkey";
       public            postgres    false    233            �           2606    24668    Uint Uint_pkey 
   CONSTRAINT     R   ALTER TABLE ONLY public."Uint"
    ADD CONSTRAINT "Uint_pkey" PRIMARY KEY ("ID");
 <   ALTER TABLE ONLY public."Uint" DROP CONSTRAINT "Uint_pkey";
       public            postgres    false    235            �           2606    24670 ,   Unit_of_measurement Unit_of_measurement_pkey 
   CONSTRAINT     p   ALTER TABLE ONLY public."Unit_of_measurement"
    ADD CONSTRAINT "Unit_of_measurement_pkey" PRIMARY KEY ("ID");
 Z   ALTER TABLE ONLY public."Unit_of_measurement" DROP CONSTRAINT "Unit_of_measurement_pkey";
       public            postgres    false    237            �           2606    24671 +   Defect_list Defect_list_ID_Type_repair_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public."Defect_list"
    ADD CONSTRAINT "Defect_list_ID_Type_repair_fkey" FOREIGN KEY ("ID_Type_repair") REFERENCES public."Type_repair"("ID") NOT VALID;
 Y   ALTER TABLE ONLY public."Defect_list" DROP CONSTRAINT "Defect_list_ID_Type_repair_fkey";
       public          postgres    false    233    4772    217            �           2606    24689 "   Employee Employee_ID_Division_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public."Employee"
    ADD CONSTRAINT "Employee_ID_Division_fkey" FOREIGN KEY ("ID_Division") REFERENCES public."Division"("ID") NOT VALID;
 P   ALTER TABLE ONLY public."Employee" DROP CONSTRAINT "Employee_ID_Division_fkey";
       public          postgres    false    4778    239    219            �           2606    24676 &   Employee Employee_ID_Organization_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public."Employee"
    ADD CONSTRAINT "Employee_ID_Organization_fkey" FOREIGN KEY ("ID_Organization") REFERENCES public."Organization"("ID") NOT VALID;
 T   ALTER TABLE ONLY public."Employee" DROP CONSTRAINT "Employee_ID_Organization_fkey";
       public          postgres    false    219    225    4764            �           2606    24702    Employee Employee_ID_Post_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public."Employee"
    ADD CONSTRAINT "Employee_ID_Post_fkey" FOREIGN KEY ("ID_Post") REFERENCES public."Post"("ID") NOT VALID;
 L   ALTER TABLE ONLY public."Employee" DROP CONSTRAINT "Employee_ID_Post_fkey";
       public          postgres    false    241    219    4780            @   �   x�u�K
�PE�7�p��}|�&\A7��c�(8rZ��R�k�ّ�	m!9�@�G��a)a�!~��S�C��� ���߬���Ɋ=��x��z���:�76�m���I�Z�enp�[b�'�5�`�G�ܲ�n��RD~CF��      B      x�3�4����� k       X   U   x�3�0����.l�[/6 �}����V s��v ��®.�+ �/6�n���˄�� gׅ}6񖋍@]@W� V7�      D   �   x��PK
�0]Ϝ�t�Lj��'�е�^@ܸw� "�@
�.�3Lo�I��B�$���	�����I��S^�$aH�t�^�l��%����@�r����#������&r�Vz~��YCy��p	��$���.2u�>CP���|���x-���p�)*�����T��ʺ�ʲ��Qv,�����      F      x������ � �      H      x������ � �      J   ,   x�3�0�.L��|a�]v(qAE�.��0E�+F��� ��      L      x������ � �      N      x������ � �      Z   4   x�3�0����.l�[/6pq^�|a��6]�{���N�;P�c���� �� �      P   \   x�3�0���[/l���bÅ}�y;.���qtqT02421�443000�3�q4014126r224�4��0T�0��3CN##c�=... `�      R   �   x���]n�@������J��Ð�
$���,)[B6W߈��JE�G}Yٻ3��=+��Q���c�-za�pAf[��.huˋ�M���Vڔ,*^u�5�'�t��Ed�qD�.���"�&�{Z#�ٲ�x~{uLlnx�٦���.�J���Nd3{/��Ur���
�G"u�Q���X��sHf��g��q�5�
o4�NM��?U��P���T�䢿G�;�tvG�o�8x)��;2����}C��˓�	���1\�      T      x������ � �      V   !   x�3估��f.#�{��9/v\l����� |��     