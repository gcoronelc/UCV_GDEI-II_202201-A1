
CREATE TABLE dbo.TIEMPO_DIM
( 
	Tiempo_KEY           integer  NOT NULL ,
	Anio                 integer  NULL ,
	Semestre             integer  NULL ,
	Trimestre            integer  NULL ,
	Mes                  char(18)  NULL ,
	Fecha                datetime  NOT NULL ,
	CONSTRAINT XPKTIEMPO_DIM PRIMARY KEY (Tiempo_KEY ASC)
)
go



CREATE TABLE dbo.PRODUCTO_DIM
( 
	Producto_key         integer  NOT NULL ,
	Nombre               varchar(150)  NOT NULL ,
	Categoria            varchar(100)  NOT NULL ,
	CONSTRAINT XPKPRODUCTO_DIM PRIMARY KEY (Producto_key ASC)
)
go



CREATE TABLE dbo.ALMACEN_DIM
( 
	ALMACEN_KEY          integer  NOT NULL ,
	Nombre               varchar(100)  NOT NULL ,
	CONSTRAINT XPKALMACEN_DIM PRIMARY KEY (ALMACEN_KEY ASC)
)
go



CREATE TABLE dbo.VENTAS_FACT
( 
	ALMACEN_KEY          integer  NOT NULL ,
	Tiempo_KEY           integer  NOT NULL ,
	Producto_key         integer  NOT NULL ,
	Cantidad             integer  NOT NULL ,
	Importe              money  NOT NULL ,
	CONSTRAINT XPKVENTAS_FACT PRIMARY KEY (ALMACEN_KEY ASC,Tiempo_KEY ASC,Producto_key ASC),
	CONSTRAINT R_3 FOREIGN KEY (ALMACEN_KEY) REFERENCES dbo.ALMACEN_DIM(ALMACEN_KEY)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION,
CONSTRAINT R_1 FOREIGN KEY (Tiempo_KEY) REFERENCES dbo.TIEMPO_DIM(Tiempo_KEY)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION,
CONSTRAINT R_2 FOREIGN KEY (Producto_key) REFERENCES dbo.PRODUCTO_DIM(Producto_key)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
)
go


