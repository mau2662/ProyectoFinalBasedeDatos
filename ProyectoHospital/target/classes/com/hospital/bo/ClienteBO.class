package com.hospital.bo;

import com.hospital.dao.ClienteDAO;
import com.hospital.db.Conexion;
import com.hospital.entity.Cliente;
import java.sql.Connection;


public class ClienteBO {

    private String mensaje = "";
    private ClienteDAO cdao = new ClienteDAO();

    public String agregarCliente(Cliente cli) {
        Connection conn = Conexion.getConnection();
        try {
            mensaje = cdao.agregarCliente(conn, cli);

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

    public String modificarCliente(Cliente cli) {

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

    public String eliminarCliente(int id) {
        Connection conn = Conexion.getConnection();
        try {
            mensaje = cdao.eliminarCliente(conn, id);

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

    public void listarCliente() {

    }
}
