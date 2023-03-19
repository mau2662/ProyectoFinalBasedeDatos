-- ***** CRUD Empleados *****

-- Insertat Empleados

CREATE OR REPLACE PROCEDURE insertar_empleado (
  p_NOMBRE IN EMPLEADO.NOMBRE%TYPE,
  p_APELLIDO IN EMPLEADO.APELLIDO%TYPE,
  p_CORREO IN EMPLEADO.CORREO%TYPE,
  p_TELEFONO IN EMPLEADO.TELEFONO%TYPE,
  p_FECHA_CONTRATACION IN EMPLEADO.FECHA_CONTRATACION%TYPE,
  p_SALARIO IN EMPLEADO.SALARIO%TYPE
) AS
BEGIN
  INSERT INTO EMPLEADO (NOMBRE, APELLIDO, CORREO, TELEFONO, FECHA_CONTRATACION, SALARIO)
  VALUES (p_NOMBRE, p_APELLIDO, p_CORREO, p_TELEFONO, p_FECHA_CONTRATACION, p_SALARIO);
  COMMIT;
END;

-- Ejemplo de como usar

BEGIN
  insertar_empleado('John', 'Doe', 'johndoe@example.com', 1234567890, TO_DATE('2023-03-19', 'YYYY-MM-DD'), 50000);
END;

-- Modificar Empleados

CREATE OR REPLACE PROCEDURE modificar_empleado (
    p_id_empleado IN EMPLEADO.ID_EMPLEADO%TYPE,
    p_nombre IN EMPLEADO.NOMBRE%TYPE DEFAULT NULL,
    p_apellido IN EMPLEADO.APELLIDO%TYPE DEFAULT NULL,
    p_correo IN EMPLEADO.CORREO%TYPE DEFAULT NULL,
    p_telefono IN EMPLEADO.TELEFONO%TYPE DEFAULT NULL,
    p_fecha_contratacion IN EMPLEADO.FECHA_CONTRATACION%TYPE DEFAULT NULL,
    p_salario IN EMPLEADO.SALARIO%TYPE DEFAULT NULL
) AS
BEGIN
    UPDATE EMPLEADO SET
        NOMBRE = NVL(p_nombre, NOMBRE),
        APELLIDO = NVL(p_apellido, APELLIDO),
        CORREO = NVL(p_correo, CORREO),
        TELEFONO = NVL(p_telefono, TELEFONO),
        FECHA_CONTRATACION = NVL(p_fecha_contratacion, FECHA_CONTRATACION),
        SALARIO = NVL(p_salario, SALARIO)
    WHERE ID_EMPLEADO = p_id_empleado;
END;

-- Ejemplo de como usar

BEGIN
  modificar_empleado(1, NULL, NULL, NULL, 5551234, NULL, 7000);
END;
/*
Para actualizar cualquier valor de un empleado solo hay que enviarlo como argumento.
Cualquier cosa que sea NULL no se va a modificar
*/

-- Eliminar Empleados

CREATE OR REPLACE PROCEDURE eliminar_empleado (
    p_id_empleado IN EMPLEADO.ID_EMPLEADO%TYPE
) AS
BEGIN
    DELETE FROM EMPLEADO WHERE ID_EMPLEADO = p_id_empleado;
    COMMIT;
END;

-- Ejemplo de como usar

BEGIN
  eliminar_empleado(1);
END;

-- Select Empleados

CREATE OR REPLACE PROCEDURE select_empleados(
    P_EMPLEADOS OUT SYS_REFCURSOR
) AS
BEGIN
    OPEN P_EMPLEADOS FOR SELECT * FROM EMPLEADO;
END;

-- Ejemplo de como usar

VAR RC_EMPLEADOS REFCURSOR;
EXEC select_empleados(:RC_EMPLEADOS);
PRINT RC_EMPLEADOS;
