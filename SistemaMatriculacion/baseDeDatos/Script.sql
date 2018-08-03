﻿CREATE DATABASE "Sistema matriculacion"
GO

USE "Sistema matriculacion"
GO

CREATE TABLE ESTUDIANTE(
	MATRICULA VARCHAR(8) PRIMARY KEY,
	NOMBRE_ESTUDIANTE VARCHAR(20) NOT NULL,
	APELLIDO_ESTUDIANTE VARCHAR(20) NOT NULL,
	FECHA_NACIMIENTO_ESTUDIANTE DATE NOT NULL,
	SEXO_ESTUDIANTE VARCHAR(1) CHECK (SEXO_ESTUDIANTE = 'M'  OR SEXO_ESTUDIANTE = 'F') NOT NULL,
	DIRECCION_ESTUDIANTE VARCHAR(200)
);

CREATE TABLE TUTOR(
	CEDULA_TUTOR VARCHAR(11) PRIMARY KEY,
	NOMBRE_TUTOR VARCHAR(15) NOT NULL,
	APELLIDO_TUTOR VARCHAR(15) NOT NULL,
	RELACION_ESTUDIANTE VARCHAR(10) NOT NULL,
	SEXO_TUTOR VARCHAR(1) CHECK (SEXO_TUTOR = 'M'  OR SEXO_TUTOR = 'F') NOT NULL,
	TELEFONO VARCHAR(10)
);

CREATE TABLE ESTUDIANTE_TUTOR(
	MATRICULA VARCHAR(8) FOREIGN KEY REFERENCES ESTUDIANTE(MATRICULA),
	CEDULA_TUTOR VARCHAR(11) FOREIGN KEY REFERENCES TUTOR(CEDULA_TUTOR),
	PRIMARY KEY(MATRICULA, CEDULA_TUTOR)
);

CREATE TABLE SECCION(
	ID_SECCION INT PRIMARY KEY,
	NOMBRE_SECCION VARCHAR(10) NOT NULL,
	CANTIDAD_ESTUDIANTES INT NOT NULL,
	HORARIO VARCHAR(MAX) NOT NULL
)

CREATE TABLE ESTUDIANTE_SECCION(
	MATRICULA VARCHAR(8) FOREIGN KEY REFERENCES ESTUDIANTE(MATRICULA) NOT NULL,
	ID_SECCION INT FOREIGN KEY REFERENCES SECCION(ID_SECCION) NOT NULL,
	PRIMARY KEY(MATRICULA, ID_SECCION)
)

CREATE TABLE MATERIA(
	ID_MATERIA INT PRIMARY KEY NOT NULL,
	NOMBRE_MATERIA VARCHAR(20) NOT NULL
)

CREATE TABLE PROFESOR(
	ID_PROFESOR INT PRIMARY KEY NOT NULL,
	NOMBRE_PROFESOR VARCHAR(20) NOT NULL,
	APELLIDO_PROFESOR VARCHAR(20) NOT NULL,
	FECHA_NACIMIENTO_PROFESOR DATE NOT NULL,
	SEXO_PROFESOR VARCHAR(1) CHECK (SEXO_PROFESOR = 'M'  OR SEXO_PROFESOR = 'F') NOT NULL,
	DIRECCION_PROFESOR VARCHAR(200),
	TELEFONO_PROFESOR VARCHAR(11) 
)

CREATE TABLE SECCION_MATERIA(
	ID_SECCION INT FOREIGN KEY REFERENCES SECCION(ID_SECCION) NOT NULL,
	ID_MATERIA INT FOREIGN KEY REFERENCES MATERIA(ID_MATERIA) NOT NULL,
	ID_PROFESOR INT FOREIGN KEY REFERENCES PROFESOR(ID_PROFESOR) NOT NULL,
	HORARIO VARCHAR(50) NOT NULL
	PRIMARY KEY(ID_SECCION, ID_MATERIA)
)

CREATE TABLE ESTUDIO(
	ID_ESTUDIO INT PRIMARY KEY,
	DESCRIPCION_ESTUDIO VARCHAR(100) NOT NULL,
	ID_PROFESOR INT FOREIGN KEY REFERENCES PROFESOR(ID_PROFESOR)
);

CREATE TABLE NOTA(
	MATRICULA VARCHAR(8) FOREIGN KEY REFERENCES ESTUDIANTE(MATRICULA),
	ID_MATERIA INT FOREIGN KEY REFERENCES MATERIA(ID_MATERIA),
	CALIFICACION INT CHECK (CALIFICACION >= 0 AND CALIFICACION <= 100),
	PRIMARY KEY(MATRICULA, ID_MATERIA)
)