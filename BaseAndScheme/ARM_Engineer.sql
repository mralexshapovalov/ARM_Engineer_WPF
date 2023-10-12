PGDMP                  	    {            ARM_Engineer    16rc1    16rc1 J    J           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            K           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            L           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            M           1262    16419    ARM_Engineer    DATABASE     �   CREATE DATABASE "ARM_Engineer" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'English_United States.1251';
    DROP DATABASE "ARM_Engineer";
                postgres    false            �            1259    16440    Approval_status    TABLE     n   CREATE TABLE public."Approval_status" (
    "ID" integer NOT NULL,
    "Name" text,
    "Description" text
);
 %   DROP TABLE public."Approval_status";
       public         heap    postgres    false            N           0    0    TABLE "Approval_status"    COMMENT     V   COMMENT ON TABLE public."Approval_status" IS 'Статус согласования';
          public          postgres    false    219            �            1259    16447    Approval_status_ID_seq    SEQUENCE     �   ALTER TABLE public."Approval_status" ALTER COLUMN "ID" ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public."Approval_status_ID_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    219            �            1259    16429    Defect_list    TABLE     h   CREATE TABLE public."Defect_list" (
    "ID" integer NOT NULL,
    "ID_Type_repair" integer NOT NULL
);
 !   DROP TABLE public."Defect_list";
       public         heap    postgres    false            �            1259    16439    Defect list_ID_seq    SEQUENCE     �   ALTER TABLE public."Defect_list" ALTER COLUMN "ID" ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public."Defect list_ID_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    217            �            1259    16540    Employee    TABLE     �   CREATE TABLE public."Employee" (
    "ID" integer NOT NULL,
    "Service_number" text,
    "L.F.P" text,
    "Division" text,
    "Year of birth" text,
    "Date_Employee" date,
    "Date_dismissal" date,
    "Post" text,
    "ID_Organization" integer
);
    DROP TABLE public."Employee";
       public         heap    postgres    false            O           0    0    TABLE "Employee"    COMMENT     <   COMMENT ON TABLE public."Employee" IS 'Сотрудник';
          public          postgres    false    229            �            1259    16545    Employee_ID_seq    SEQUENCE     �   ALTER TABLE public."Employee" ALTER COLUMN "ID" ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public."Employee_ID_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    229            �            1259    16471    Knot    TABLE     K   CREATE TABLE public."Knot" (
    "ID" integer NOT NULL,
    "Name" text
);
    DROP TABLE public."Knot";
       public         heap    postgres    false            P           0    0    TABLE "Knot"    COMMENT     .   COMMENT ON TABLE public."Knot" IS 'Узел';
          public          postgres    false    226            �            1259    16478    Knot_ID_seq    SEQUENCE     �   ALTER TABLE public."Knot" ALTER COLUMN "ID" ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public."Knot_ID_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    226            �            1259    16546    Material    TABLE     �   CREATE TABLE public."Material" (
    "ID" integer NOT NULL,
    "Article" text,
    "Name" text,
    "Unit_measurement" text,
    "Cost" text
);
    DROP TABLE public."Material";
       public         heap    postgres    false            �            1259    16551    Material_ID_seq    SEQUENCE     �   ALTER TABLE public."Material" ALTER COLUMN "ID" ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public."Material_ID_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    231            �            1259    16573    Organization    TABLE     S   CREATE TABLE public."Organization" (
    "ID" integer NOT NULL,
    "Name" text
);
 "   DROP TABLE public."Organization";
       public         heap    postgres    false            �            1259    16585    Organization_ID_seq    SEQUENCE     �   ALTER TABLE public."Organization" ALTER COLUMN "ID" ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public."Organization_ID_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    237            �            1259    16456    Part    TABLE     �   CREATE TABLE public."Part" (
    "ID" integer NOT NULL,
    "Article" text,
    "Name" text,
    "ID_Unit_of_measurement" text NOT NULL,
    "ID_Unit" text,
    "ID_Knot" text
);
    DROP TABLE public."Part";
       public         heap    postgres    false            Q           0    0    TABLE "Part"    COMMENT     A   COMMENT ON TABLE public."Part" IS 'Запасная часть';
          public          postgres    false    223            �            1259    16463    Part_ID_seq    SEQUENCE     �   ALTER TABLE public."Part" ALTER COLUMN "ID" ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public."Part_ID_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    223            �            1259    16552    Part_defect_list    TABLE     >  CREATE TABLE public."Part_defect_list" (
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
       public         heap    postgres    false            �            1259    16557    Part_defect_list_ID_seq    SEQUENCE     �   ALTER TABLE public."Part_defect_list" ALTER COLUMN "ID" ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public."Part_defect_list_ID_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    233            �            1259    16558    Technic    TABLE     �   CREATE TABLE public."Technic" (
    "ID" integer NOT NULL,
    "ID_Type_of_equipment" text NOT NULL,
    "Name_of_the equipment" text,
    "Inventory_number" text,
    "Factory_number" text,
    "State_number" text,
    "Year_of_release" text
);
    DROP TABLE public."Technic";
       public         heap    postgres    false            R           0    0    TABLE "Technic"    COMMENT     7   COMMENT ON TABLE public."Technic" IS 'Техника';
          public          postgres    false    235            �            1259    16563    Technic_ID_seq    SEQUENCE     �   ALTER TABLE public."Technic" ALTER COLUMN "ID" ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public."Technic_ID_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    235            �            1259    16420    Type_repair    TABLE     j   CREATE TABLE public."Type_repair" (
    "ID" integer NOT NULL,
    "Name" text,
    "Description" text
);
 !   DROP TABLE public."Type_repair";
       public         heap    postgres    false            S           0    0    TABLE "Type_repair"    COMMENT     B   COMMENT ON TABLE public."Type_repair" IS 'Вид ремонта';
          public          postgres    false    215            �            1259    16428    Type_repair_ID_seq    SEQUENCE     �   ALTER TABLE public."Type_repair" ALTER COLUMN "ID" ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public."Type_repair_ID_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    215            �            1259    16464    Uint    TABLE     K   CREATE TABLE public."Uint" (
    "ID" integer NOT NULL,
    "Name" text
);
    DROP TABLE public."Uint";
       public         heap    postgres    false            T           0    0    TABLE "Uint"    COMMENT     4   COMMENT ON TABLE public."Uint" IS 'Агрегат';
          public          postgres    false    225            �            1259    16479    Uint_ID_seq    SEQUENCE     �   ALTER TABLE public."Uint" ALTER COLUMN "ID" ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public."Uint_ID_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    225            �            1259    16448    Unit_of_measurement    TABLE     Z   CREATE TABLE public."Unit_of_measurement" (
    "ID" integer NOT NULL,
    "Name" text
);
 )   DROP TABLE public."Unit_of_measurement";
       public         heap    postgres    false            U           0    0    TABLE "Unit_of_measurement"    COMMENT     V   COMMENT ON TABLE public."Unit_of_measurement" IS 'Единица измерения';
          public          postgres    false    221            �            1259    16455    Unit_of_measurement_ID_seq    SEQUENCE     �   ALTER TABLE public."Unit_of_measurement" ALTER COLUMN "ID" ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public."Unit_of_measurement_ID_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    221            4          0    16440    Approval_status 
   TABLE DATA           H   COPY public."Approval_status" ("ID", "Name", "Description") FROM stdin;
    public          postgres    false    219   �Q       2          0    16429    Defect_list 
   TABLE DATA           ?   COPY public."Defect_list" ("ID", "ID_Type_repair") FROM stdin;
    public          postgres    false    217   dR       >          0    16540    Employee 
   TABLE DATA           �   COPY public."Employee" ("ID", "Service_number", "L.F.P", "Division", "Year of birth", "Date_Employee", "Date_dismissal", "Post", "ID_Organization") FROM stdin;
    public          postgres    false    229   �R       ;          0    16471    Knot 
   TABLE DATA           .   COPY public."Knot" ("ID", "Name") FROM stdin;
    public          postgres    false    226   6S       @          0    16546    Material 
   TABLE DATA           Y   COPY public."Material" ("ID", "Article", "Name", "Unit_measurement", "Cost") FROM stdin;
    public          postgres    false    231   SS       F          0    16573    Organization 
   TABLE DATA           6   COPY public."Organization" ("ID", "Name") FROM stdin;
    public          postgres    false    237   pS       8          0    16456    Part 
   TABLE DATA           i   COPY public."Part" ("ID", "Article", "Name", "ID_Unit_of_measurement", "ID_Unit", "ID_Knot") FROM stdin;
    public          postgres    false    223   �S       B          0    16552    Part_defect_list 
   TABLE DATA           �   COPY public."Part_defect_list" ("ID", "ID_Defect_list", "ID_Type_repair", "ID_Employee", "ID_Part", "ID_Material", "Operating_time", "Date_defect_list", "Date_document_created", "Numer_document") FROM stdin;
    public          postgres    false    233   �S       D          0    16558    Technic 
   TABLE DATA           �   COPY public."Technic" ("ID", "ID_Type_of_equipment", "Name_of_the equipment", "Inventory_number", "Factory_number", "State_number", "Year_of_release") FROM stdin;
    public          postgres    false    235   �S       0          0    16420    Type_repair 
   TABLE DATA           D   COPY public."Type_repair" ("ID", "Name", "Description") FROM stdin;
    public          postgres    false    215   RT       :          0    16464    Uint 
   TABLE DATA           .   COPY public."Uint" ("ID", "Name") FROM stdin;
    public          postgres    false    225   `U       6          0    16448    Unit_of_measurement 
   TABLE DATA           =   COPY public."Unit_of_measurement" ("ID", "Name") FROM stdin;
    public          postgres    false    221   }U       V           0    0    Approval_status_ID_seq    SEQUENCE SET     F   SELECT pg_catalog.setval('public."Approval_status_ID_seq"', 5, true);
          public          postgres    false    220            W           0    0    Defect list_ID_seq    SEQUENCE SET     B   SELECT pg_catalog.setval('public."Defect list_ID_seq"', 2, true);
          public          postgres    false    218            X           0    0    Employee_ID_seq    SEQUENCE SET     ?   SELECT pg_catalog.setval('public."Employee_ID_seq"', 3, true);
          public          postgres    false    230            Y           0    0    Knot_ID_seq    SEQUENCE SET     <   SELECT pg_catalog.setval('public."Knot_ID_seq"', 1, false);
          public          postgres    false    227            Z           0    0    Material_ID_seq    SEQUENCE SET     @   SELECT pg_catalog.setval('public."Material_ID_seq"', 1, false);
          public          postgres    false    232            [           0    0    Organization_ID_seq    SEQUENCE SET     C   SELECT pg_catalog.setval('public."Organization_ID_seq"', 2, true);
          public          postgres    false    238            \           0    0    Part_ID_seq    SEQUENCE SET     <   SELECT pg_catalog.setval('public."Part_ID_seq"', 1, false);
          public          postgres    false    224            ]           0    0    Part_defect_list_ID_seq    SEQUENCE SET     H   SELECT pg_catalog.setval('public."Part_defect_list_ID_seq"', 1, false);
          public          postgres    false    234            ^           0    0    Technic_ID_seq    SEQUENCE SET     >   SELECT pg_catalog.setval('public."Technic_ID_seq"', 1, true);
          public          postgres    false    236            _           0    0    Type_repair_ID_seq    SEQUENCE SET     B   SELECT pg_catalog.setval('public."Type_repair_ID_seq"', 4, true);
          public          postgres    false    216            `           0    0    Uint_ID_seq    SEQUENCE SET     <   SELECT pg_catalog.setval('public."Uint_ID_seq"', 1, false);
          public          postgres    false    228            a           0    0    Unit_of_measurement_ID_seq    SEQUENCE SET     J   SELECT pg_catalog.setval('public."Unit_of_measurement_ID_seq"', 3, true);
          public          postgres    false    222            �           2606    16446 $   Approval_status Approval_status_pkey 
   CONSTRAINT     h   ALTER TABLE ONLY public."Approval_status"
    ADD CONSTRAINT "Approval_status_pkey" PRIMARY KEY ("ID");
 R   ALTER TABLE ONLY public."Approval_status" DROP CONSTRAINT "Approval_status_pkey";
       public            postgres    false    219            �           2606    16433    Defect_list Defect list_pkey 
   CONSTRAINT     l   ALTER TABLE ONLY public."Defect_list"
    ADD CONSTRAINT "Defect list_pkey" PRIMARY KEY ("ID_Type_repair");
 J   ALTER TABLE ONLY public."Defect_list" DROP CONSTRAINT "Defect list_pkey";
       public            postgres    false    217            �           2606    16565    Employee Employee_pkey 
   CONSTRAINT     Z   ALTER TABLE ONLY public."Employee"
    ADD CONSTRAINT "Employee_pkey" PRIMARY KEY ("ID");
 D   ALTER TABLE ONLY public."Employee" DROP CONSTRAINT "Employee_pkey";
       public            postgres    false    229            �           2606    16477    Knot Knot_pkey 
   CONSTRAINT     R   ALTER TABLE ONLY public."Knot"
    ADD CONSTRAINT "Knot_pkey" PRIMARY KEY ("ID");
 <   ALTER TABLE ONLY public."Knot" DROP CONSTRAINT "Knot_pkey";
       public            postgres    false    226            �           2606    16567    Material Material_pkey 
   CONSTRAINT     Z   ALTER TABLE ONLY public."Material"
    ADD CONSTRAINT "Material_pkey" PRIMARY KEY ("ID");
 D   ALTER TABLE ONLY public."Material" DROP CONSTRAINT "Material_pkey";
       public            postgres    false    231            �           2606    16579    Organization Organization_pkey 
   CONSTRAINT     b   ALTER TABLE ONLY public."Organization"
    ADD CONSTRAINT "Organization_pkey" PRIMARY KEY ("ID");
 L   ALTER TABLE ONLY public."Organization" DROP CONSTRAINT "Organization_pkey";
       public            postgres    false    237            �           2606    16569 &   Part_defect_list Part_defect_list_pkey 
   CONSTRAINT     v   ALTER TABLE ONLY public."Part_defect_list"
    ADD CONSTRAINT "Part_defect_list_pkey" PRIMARY KEY ("ID_Defect_list");
 T   ALTER TABLE ONLY public."Part_defect_list" DROP CONSTRAINT "Part_defect_list_pkey";
       public            postgres    false    233            �           2606    16462    Part Part_pkey 
   CONSTRAINT     f   ALTER TABLE ONLY public."Part"
    ADD CONSTRAINT "Part_pkey" PRIMARY KEY ("ID_Unit_of_measurement");
 <   ALTER TABLE ONLY public."Part" DROP CONSTRAINT "Part_pkey";
       public            postgres    false    223            �           2606    16571    Technic Technic_pkey 
   CONSTRAINT     j   ALTER TABLE ONLY public."Technic"
    ADD CONSTRAINT "Technic_pkey" PRIMARY KEY ("ID_Type_of_equipment");
 B   ALTER TABLE ONLY public."Technic" DROP CONSTRAINT "Technic_pkey";
       public            postgres    false    235            �           2606    16426    Type_repair Type_repair_pkey 
   CONSTRAINT     `   ALTER TABLE ONLY public."Type_repair"
    ADD CONSTRAINT "Type_repair_pkey" PRIMARY KEY ("ID");
 J   ALTER TABLE ONLY public."Type_repair" DROP CONSTRAINT "Type_repair_pkey";
       public            postgres    false    215            �           2606    16470    Uint Uint_pkey 
   CONSTRAINT     R   ALTER TABLE ONLY public."Uint"
    ADD CONSTRAINT "Uint_pkey" PRIMARY KEY ("ID");
 <   ALTER TABLE ONLY public."Uint" DROP CONSTRAINT "Uint_pkey";
       public            postgres    false    225            �           2606    16454 ,   Unit_of_measurement Unit_of_measurement_pkey 
   CONSTRAINT     p   ALTER TABLE ONLY public."Unit_of_measurement"
    ADD CONSTRAINT "Unit_of_measurement_pkey" PRIMARY KEY ("ID");
 Z   ALTER TABLE ONLY public."Unit_of_measurement" DROP CONSTRAINT "Unit_of_measurement_pkey";
       public            postgres    false    221            �           2606    16434 +   Defect_list Defect_list_ID_Type_repair_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public."Defect_list"
    ADD CONSTRAINT "Defect_list_ID_Type_repair_fkey" FOREIGN KEY ("ID_Type_repair") REFERENCES public."Type_repair"("ID") NOT VALID;
 Y   ALTER TABLE ONLY public."Defect_list" DROP CONSTRAINT "Defect_list_ID_Type_repair_fkey";
       public          postgres    false    217    4744    215            �           2606    16580 &   Employee Employee_ID_Organization_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public."Employee"
    ADD CONSTRAINT "Employee_ID_Organization_fkey" FOREIGN KEY ("ID_Organization") REFERENCES public."Organization"("ID") NOT VALID;
 T   ALTER TABLE ONLY public."Employee" DROP CONSTRAINT "Employee_ID_Organization_fkey";
       public          postgres    false    229    237    4766            4   �   x�u�K
�PE�7�p��}|�&\A7��c�(8rZ��R�k�ّ�	m!9�@�G��a)a�!~��S�C��� ���߬���Ɋ=��x��z���:�76�m���I�Z�enp�[b�'�5�`�G�ܲ�n��RD~CF��      2      x�3�4����� k       >   �   x�]M�	�@|�Uqx�`HV��!j�G�/b1$A�X�lG�]Pav�vv<1�/v�+Z4�Fk���]<�4��+�R*7r���K�j?�og��yF�CX�WP����7!��M�A����$�܍�$5Z����Sŗ?�Nwt��|�Ų�O0�3�| /'��      ;      x������ � �      @      x������ � �      F   ,   x�3�0�.L��|a�]v(qAE�.��0E�+F��� ��      8      x������ � �      B      x������ � �      D   \   x�3�0���[/l���bÅ}�y;.���qtqT02421�443000�3�q4014126r224�4��0T�0��3CN##c�=... `�      0   �   x���]n�@������J��Ð�
$���,)[B6W߈��JE�G}Yٻ3��=+��Q���c�-za�pAf[��.huˋ�M���Vڔ,*^u�5�'�t��Ed�qD�.���"�&�{Z#�ٲ�x~{uLlnx�٦���.�J���Nd3{/��Ur���
�G"u�Q���X��sHf��g��q�5�
o4�NM��?U��P���T�䢿G�;�tvG�o�8x)��;2����}C��˓�	���1\�      :      x������ � �      6   !   x�3估��f.#�{��9/v\l����� |��     