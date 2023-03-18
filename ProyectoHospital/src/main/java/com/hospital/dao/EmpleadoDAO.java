/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.hospital.dao;

import com.hospital.entity.Empleado;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.SQLException;
import javax.swing.JTable;

/**
 *
 * @author varga
 */
public class EmpleadoDAO {

    private String mensaje = "";

    public String agregarEmpleado(Connection con, Empleado emp) {
        PreparedStatement pst = null;
        String sql = "INSERT INTO GENERICO.EMPLEADO (ID_EMPLEADO, NOMBRE"
                + "APELLIDO, CORREO,TELEFONO,FECHA_CONTRATACION, SALARIO)"
                + "VALUES(EMPLEADO_SEQ.NEXVAL,?,?,?,?,?)";

        try {
            pst = con.prepareStatement(sql);
            pst.setString(1, emp.getNombre());
            pst.setString(1, emp.getApellido());
            pst.setString(2, emp.getCorreo());
            pst.setString(3, emp.getFecha_Contratacion());
            pst.setString(4, emp.getTelefono());
            pst.setInt(5, emp.getSalario());
            mensaje = "Guardado Correctamente";
            pst.execute();
            pst.close();

        } catch (SQLException e) {

            mensaje = "No se pudo Guardar Correctamente \n " + e.getMessage();

        }

        return mensaje;
    }

    public String modificarEmpleado(Connection con, Empleado emp) {
        PreparedStatement pst = null;
        String sql = "UPDATE EMPLEADO SET NOMBRE = ?, APELLIDO =?, CORREO=?"
                + "FECHA_CONTRATACION=?, TELEFONO=?,SALARIO=?"
                + "WHERE ID_EMPLEADO =?";

        try {
            pst = con.prepareStatement(sql);
            pst.setString(1, emp.getNombre());
            pst.setString(1, emp.getApellido());
            pst.setString(2, emp.getCorreo());
            pst.setString(3, emp.getFecha_Contratacion());
            pst.setString(4, emp.getTelefono());
            pst.setInt(5, emp.getSalario());
            pst.setInt(6, emp.getId_Empleado());
            mensaje = "Actualizado Correctamente";
            pst.execute();
            pst.close();

        } catch (SQLException e) {

            mensaje = "No se pudo Actualizar Correctamente \n " + e.getMessage();

        }

        return mensaje;

    }

    public String eliminarEmpleado(Connection con, int id) {

        PreparedStatement pst = null;
        String sql = "DELETE FROM EMPLEADO WHERE ID_EMPLEADO =?";

        try {
            pst = con.prepareStatement(sql);
            pst.setInt(1, id);
            mensaje = "Actualizado Correctamente";
            pst.execute();
            pst.close();

        } catch (SQLException e) {

            mensaje = "No se pudo Actualizar Correctamente \n " + e.getMessage();

        }
        return mensaje;

    }

    public void listarEmpleado(Connection con, JTable tabla) {

    }

}
