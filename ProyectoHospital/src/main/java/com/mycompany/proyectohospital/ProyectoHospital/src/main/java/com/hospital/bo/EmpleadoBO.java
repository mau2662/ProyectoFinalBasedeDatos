/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.hospital.bo;

import com.hospital.dao.EmpleadoDAO;
import com.hospital.db.Conexion;
import com.hospital.entity.Empleado;
import java.sql.Connection;

/**
 *
 * @author varga
 */
public class EmpleadoBO {

    private String mensaje = "";
    private EmpleadoDAO edao = new EmpleadoDAO();

    public String agregarEmpleado(Empleado emp) {
        Connection conn = Conexion.getConnection();
        try {
            mensaje = edao.agregarEmpleado(conn, emp);

        } catch (Exception e) {
            mensaje = mensaje + " " + e.getMessage();

        } finally {
            try {
                if (conn != null) {
                    conn.close();
                }
            } catch (Exception e) {
                mensaje = mensaje + " " + e.getMessage();
            }
        }
        return mensaje;

    }

    public String modificarEmpleado(Empleado emp) {

        Connection conn = Conexion.getConnection();
        try {
            mensaje = edao.modificarEmpleado(conn, emp);

        } catch (Exception e) {
            mensaje = mensaje + " " + e.getMessage();

        } finally {
            try {
                if (conn != null) {
                    conn.close();
                }
            } catch (Exception e) {
                mensaje = mensaje + " " + e.getMessage();
            }
        }
        return mensaje;

    }

    public String eliminarEmpleado(int id) {
        Connection conn = Conexion.getConnection();
        try {
            mensaje = edao.eliminarEmpleado(conn, id);

        } catch (Exception e) {
            mensaje = mensaje + " " + e.getMessage();

        } finally {
            try {
                if (conn != null) {
                    conn.close();
                }
            } catch (Exception e) {
                mensaje = mensaje + " " + e.getMessage();
            }
        }
        return mensaje;

    }

    public void listarEmpleado() {

    }
}
