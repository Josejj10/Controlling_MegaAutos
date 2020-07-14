package pe.com.megaautos.model;


import java.util.ArrayList;
import java.util.Date;
import java.util.HashMap;
import java.util.List;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Rodrigo
 */
public class Reporte {
    private int idReporte;
    private int idExcelEntrada;//"El reporte ya ha sido creado"
    private int idExcelSalida;
    private Date fechaInicio;
    private Date fechaFin;
    private Date fechaCreacion;
    private int idUsuario;
    private String nombreUsuario;
    private String tipoReporte;
    private String titulo;
    private Double ingresos;
    private Double egresos;
    private Sede sede;
    private HashMap<String, ArrayList<OrdenTrabajo>> mapaDetalle;
    private HashMap<String, ArrayList<Double>> mapaDetalleMontos;

    public Reporte() {
        this.sede = new Sede();
    }

    public String getNombreUsuario() {
        return nombreUsuario;
    }

    public void setNombreUsuario(String nombreUsuario) {
        this.nombreUsuario = nombreUsuario;
    }

    public HashMap<String, ArrayList<Double>> getMapaDetalleMontos() {
        return mapaDetalleMontos;
    }

    public void setMapaDetalleMontos(HashMap<String, ArrayList<Double>> mapaDetalleMontos) {
        this.mapaDetalleMontos = mapaDetalleMontos;
    }

    public HashMap<String, ArrayList<OrdenTrabajo>> getMapaDetalle() {
        return mapaDetalle;
    }

    public void setMapaDetalle(HashMap<String, ArrayList<OrdenTrabajo>> mapaDetalle) {
        this.mapaDetalle = mapaDetalle;
    }

    
    
    public int getIdReporte() {
        return idReporte;
    }

    public void setIdReporte(int idReporte) {
        this.idReporte = idReporte;
    }

    public Date getFechaCreacion() {
        return fechaCreacion;
    }

    public void setFechaCreacion(Date fechaCreacion) {
        this.fechaCreacion = fechaCreacion;
    }

    public Double getIngresos() {
        return ingresos;
    }

    public void setIngresos(Double ingresos) {
        this.ingresos = ingresos;
    }

    public Double getEgresos() {
        return egresos;
    }

    public void setEgresos(Double egresos) {
        this.egresos = egresos;
    }

    
    
    public int getIdExcelEntrada() {
        return idExcelEntrada;
    }

    public void setIdExcelEntrada(int idExcelEntrada) {
        this.idExcelEntrada = idExcelEntrada;
    }

    public int getIdExcelSalida() {
        return idExcelSalida;
    }

    public void setIdExcelSalida(int idExcelSalida) {
        this.idExcelSalida = idExcelSalida;
    }

    public Date getFechaInicio() {
        return fechaInicio;
    }

    public void setFechaInicio(Date fechaInicio) {
        this.fechaInicio = fechaInicio;
    }

    public Date getFechaFin() {
        return fechaFin;
    }

    public void setFechaFin(Date fechaFin) {
        this.fechaFin = fechaFin;
    }

    public int getIdUsuario() {
        return idUsuario;
    }

    public void setIdUsuario(int idUsuario) {
        this.idUsuario = idUsuario;
    }

    
    
    public String getTipoReporte() {
        return tipoReporte;
    }

    public void setTipoReporte(String tipoReporte) {
        this.tipoReporte = tipoReporte;
    }

    public String getTitulo() {
        return titulo;
    }

    public void setTitulo(String titulo) {
        this.titulo = titulo;
    }

    public Sede getSede() {
        return sede;
    }

    public void setSede(Sede sede) {
        this.sede = sede;
    }

    
}
