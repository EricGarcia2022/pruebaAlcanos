INSERT INTO Enfermedad (Nombre) VALUES ('Diabetes'),('Hipertensión'),('Asma');
INSERT INTO Tratamiento (Nombre) VALUES ('Insulina'),('Betabloqueantes'),('Metaproterenol');
INSERT INTO Medicamento (Nombre) VALUES ('Metamorfina'),('Ateneol'),('Albuterol');

INSERT INTO EnfermedadTratamiento (Enfermedad, TratamientoID) VALUES(1,1), (2,2), (1,2);
INSERT INTO TratamientoMedicamento (TratamientoID, Medicamento) VALUES(1,1), (2,2), (3,3);