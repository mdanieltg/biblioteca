CREATE DATABASE Biblioteca CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE Biblioteca;

CREATE TABLE Autor
(
    id_autor INT AUTO_INCREMENT PRIMARY KEY,
    nombre   VARCHAR(50) UNIQUE NOT NULL
);

CREATE TABLE Genero
(
    id_genero INT AUTO_INCREMENT PRIMARY KEY,
    nombre    VARCHAR(20) UNIQUE NOT NULL
);

CREATE TABLE Editorial
(
    id_editorial INT AUTO_INCREMENT PRIMARY KEY,
    nombre       VARCHAR(40) UNIQUE NOT NULL
);

CREATE TABLE Libro
(
    isbn              BIGINT UNSIGNED PRIMARY KEY,
    id_autor          INT          NOT NULL,
    id_editorial      INT          NOT NULL,
    titulo            VARCHAR(100) NOT NULL,
    img_referencia    VARCHAR(255) NOT NULL,
    year              YEAR         NOT NULL,
    descripcion       TEXT         NOT NULL,
    edicion           INT          NOT NULL,
    ubicacion_archivo VARCHAR(255) NOT NULL,
    FOREIGN KEY (id_autor) REFERENCES Autor (id_autor),
    FOREIGN KEY (id_editorial) REFERENCES Editorial (id_editorial)
);

CREATE TABLE LibroHasGenero
(
    id_lhg    INT AUTO_INCREMENT PRIMARY KEY,
    id_libro  BIGINT UNSIGNED NOT NULL,
    id_genero INT             NOT NULL,
    FOREIGN KEY (id_libro) REFERENCES Libro (isbn),
    FOREIGN KEY (id_genero) REFERENCES Genero (id_genero)
);

CREATE TABLE Usuario
(
    id_usuario VARCHAR(14) PRIMARY KEY,
    tipo       ENUM ('Lector', 'Bibliotecario', 'Admin') NOT NULL,
    nombre     VARCHAR(50)                               NOT NULL,
    nacimiento DATE                                      NOT NULL,
    correo     VARCHAR(255)                              NOT NULL UNIQUE,
    psswd      VARCHAR(255)                              NOT NULL
);

CREATE TABLE Favorito
(
    id_favorito INT UNSIGNED PRIMARY KEY,
    id_usuario  VARCHAR(14)     NOT NULL,
    id_libro    BIGINT UNSIGNED NOT NULL,
    FOREIGN KEY (id_usuario) REFERENCES Usuario (id_usuario),
    FOREIGN KEY (id_libro) REFERENCES Libro (isbn)
);
