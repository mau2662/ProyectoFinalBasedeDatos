package com.hospital.entity;

public class Medicamento {

    private int id_Medicamento;
    private String nombre;
    private String farmaceutica;
    private String fecha_Ingreso;
    private String fecha_Vencimiento;

    public Medicamento() {
    }

    public Medicamento(int id_Medicamento, String nombre, String farmaceutica, String fecha_Ingreso, String fecha_Vencimiento) {
        this.id_Medicamento = id_Medicamento;
        this.nombre = nombre;
        this.farmaceutica = farmaceutica;
        this.fecha_Ingreso = fecha_Ingreso;
        this.fecha_Vencimiento = fecha_Vencimiento;
    }

    public int getId_Medicamento() {
        return id_Medicamento;
    }

    public void setId_Medicamento(int id_Medicamento) {
        this.id_Medicamento = id_Medicamento;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getFarmaceutica() {
        return farmaceutica;
    }

    public void setFarmaceutica(String farmaceutica) {
        this.farmaceutica = farmaceutica;
    }

    public String getFecha_Ingreso() {
        return fecha_Ingreso;
    }

    public void setFecha_Ingreso(String fecha_Ingreso) {
        this.fecha_Ingreso = fecha_Ingreso;
    }

    public String getFecha_Vencimiento() {
        return fecha_Vencimiento;
    }

    public void setFecha_Vencimiento(String fecha_Vencimiento) {
        this.fecha_Vencimiento = fecha_Vencimiento;
    }


    @Override
    public String toString() {
        return "Medicamento{" + "id_Medicamento=" + id_Medicamento + ", nombre=" + nombre + ", farmaceutica=" + farmaceutica + ", fecha de ingreso=" + fecha_Ingreso + ", fecha de vencimiento=" + fecha_Vencimiento + '}';
    }



}
