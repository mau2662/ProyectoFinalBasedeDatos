
package com.hospital.dao;

import com.hospital.entity.Medicamento;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.SQLException;
import javax.swing.JTable;


public class MedicamentoDAO {

    private String mensaje = "";

    public String agregarMedicamento(Connection con, Medicamento med) {
        PreparedStatement pst = null;
        String sql = "INSERT INTO GENERICO.MEDICAMENTO VALUES(3,?,?,?,?)";

        try {
            pst = con.prepareStatement(sql);
            pst.setString(1, med.getNombre());
            pst.setString(2, med.getFarmaceutica());
            pst.setString(3, med.getFecha_Ingreso());
            pst.setString(4, med.getFecha_Vencimiento());
            mensaje = "Guardado Correctamente";
            pst.execute();
            pst.close();

        } catch (SQLException e) {

            mensaje = "No se pudo Guardar Correctamente \n " + e.getMessage();

        }

        return mensaje;
    }

    public String modificarMedicamento(Connection con, Medicamento med) {
        PreparedStatement pst = null;
        String sql = "UPDATE GENERICO.MEDICAMENTO SET NOMBRE= ?, FARMACEUTICA =?, FECHA_INGRESO =?, FECHA_VENCIMIENTO =?"
                + "WHERE ID_MEDICAMENTO =?";

        try {
            pst = con.prepareStatement(sql);
            pst.setString(1, med.getNombre());
            pst.setString(2, med.getFarmaceutica());
            pst.setString(3, med.getFecha_Ingreso());
            pst.setString(4, med.getFecha_Vencimiento());
            pst.setInt(5, med.getId_Medicamento());
            mensaje = "Modificado Correctamente";
            pst.execute();
            pst.close();

        } catch (SQLException e) {

            mensaje = "No se pudo Actualizar Correctamente \n " + e.getMessage();

        }

        return mensaje;

    }

    public String eliminarMedicamento(Connection con, int id) {

        PreparedStatement pst = null;
        String sql = "DELETE FROM MEDICAMENTO WHERE ID_MEDICAMENTO =?";

        try {
            pst = con.prepareStatement(sql);
            pst.setInt(1, id);
            mensaje = "Eliminado Correctamente";
            pst.execute();
            pst.close();

        } catch (SQLException e) {

            mensaje = "No se pudo eliminar Correctamente \n " + e.getMessage();

        }
        return mensaje;

    }

    public void listarMedicamento(Connection con, JTable tabla) {

    }

}
