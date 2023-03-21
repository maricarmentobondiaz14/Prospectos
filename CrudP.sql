drop table promotores;
CREATE TABLE promotores 
(id_promotor      NUMERIC(5) IDENTITY(1,1) PRIMARY KEY NOT NULL 	 
,usuario    	  VARCHAR(12) 	NOT NULL 	
,password	      VARCHAR(12) 	NOT NULL 	 
,nombre           VARCHAR(12) 	NOT NULL 
,puesto 	      VARCHAR(30)   NOT NULL	 
,rfc		      VARCHAR(13) 	NOT NULL 		
,telefono         VARCHAR(20) 	NOT NULL 		
,correo		      VARCHAR(30) 	NOT NULL 		

);
drop table prospectos;
CREATE TABLE prospectos
(id_prospecto   NUMERIC(5) IDENTITY(1,1) PRIMARY KEY NOT NULL
,nombreP    	VARCHAR(12) 	NOT NULL 		
,apellidoP      VARCHAR(12)     NOT NULL
,apellidoM      VARCHAR(12)     NULL
,calle          VARCHAR(20)     NOT NULL
,numeroCasa     VARCHAR(10)     NOT NULL
,colonia        VARCHAR(20)     NOT NULL
,codigoPostal   NUMERIC(5)      NOT NULL
,telefono       VARCHAR(20)     NOT NULL
,rfc            VARCHAR(12)     NOT NULL
,status         NUMERIC(1) 		DEFAULT 1
,observaciones  VARCHAR(30)     NULL        
);
drop table documentos;
CREATE TABLE documentos 
(id_documento    NUMERIC(5)	IDENTITY(1,1)   PRIMARY KEY NOT NULL 	
,id_prospecto    NUMERIC(5) 	NOT NULL 		
,url             VARCHAR(1000)  NOT NULL
,CONSTRAINT doc_id_pros_fk FOREIGN KEY  (id_prospecto) REFERENCES prospectos (id_prospecto)
);