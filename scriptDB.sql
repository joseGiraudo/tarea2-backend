CREATE DATABASE usuariosDB;
USE usuariosDB;


CREATE TABLE usuarios (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(50) NOT NULL,
    edad INT NOT NULL,
    activo BOOLEAN DEFAULT TRUE
);

INSERT INTO usuarios(nombre, edad)
VALUES("Jose", 24),
	("Juan", 28)
	
SELECT * FROM usuarios