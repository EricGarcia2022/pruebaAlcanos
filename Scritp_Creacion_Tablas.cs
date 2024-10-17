CREATE TABLE Enfermedad(
    ID INT PRIMARY KEY IDENTY(1,1),
    Nombre NVARCHAR(100)NOT NULL
);

CREATE TABLE Tratamiento (
    ID INT PRIMARY KEY IDENTY(1,1),
    Nombre NVARCHAR(100) NOT NULL
);

CREATE TABLE Medicamento(
    ID INT PRIMARY KEY IDENTY(1,1),
    Nombre NVARCHAR(100) NOT NULL
);

CREATE TABLE TratamientoMedicamento(
    Tratamiento ID INT,
    Medicamento ID INT,
    PRIMARY KEY (Tratamiento ID, Medicamento ID),
    FOREGIN KEY (Tratamiento ID) REFERENCES Tratamiento(ID),
    FOREGIN KEY (Medicamento ID) REFERENCES Medicamento(ID)
)
