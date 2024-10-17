//Obtener  enfermedades con mas de 6 medicamentos diferentes
SELECT e.Nombre
FROM Enfermedad e
JOIN EnfermedadTratamiento et ON e.ID = et.EnfermedadID
JOIN TratamientoMedicamento tm ON et.TratamientoID = tm.TratamientoID
GROUP BY e.ID, e.Nombre
HAVING COUNT(DISTINTC tm.MedicamentoID) > 6;
// Obtener enfermedades con entre 7 y 12 medicamentos y al menos 3tratamientos.
SELECT e.Nombre
FROM Enfermedad e
JOIN EnfermedadTratamiento et ON e.ID = et.EnfermedadID
JOIN TratamientoMedicamento tm ON et.TratamientoID = tm.TratamientoID
GROUP BY e.ID, e.Nombre
HAVING COUNT(DISTINTC tm.MedicamentoID) BETWEEN 7 AND 12 AND COUNT(DISTINTC et.TratamientoID) >=3;

//3 Medicamentos indicados en tratamientos de menos de 2 enfermedades.
SELECT m.Nombre
FROM Medicamento m
JOIN TratamientoMedicamento tm ON m.ID = tm.MedicamentoID
JOIN EnfermedadTratamiento et ON tm.TratamientoID = et.TratamientoID
GROUP BY m.ID, m.Nombre
HAVING COUNT(DISTINCT et.EnfermedadID) < 2;

//4. Cantidad de tratamientos y medicamentos por enfermedad.
SELECT e.Nombre, COUNT(DISTINCT et.TratamientoID) AS CantidadTratamientos, COUNT(DISTINCT tm.MedicamentoID) AS CantidadMedicamentos
FROM Enfermedad e
LEFT JOIN EnfermedadTratamiento et ON e.ID = et.EnfermedadID
LEFT JOIN TratamientoMedicamento tm ON et.TratamientoID = tm.Tratamiento
GROUP BY e.ID, e.Nombre;