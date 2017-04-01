package model;

/**
 * Created by aluno on 28/10/2016.
 */

public class QR {
    int id_qrc;
    private String login_qrc;
    private String senha_qrc;
    private String dthr_qrc;
    private int ativo_qrc;




    public int getId_qrc() {
        return id_qrc;
    }

    public void setId_qrc(int id_qrc) {
        this.id_qrc = id_qrc;
    }

    public String getLogin_qrc() {
        return login_qrc;
    }

    public void setLogin_qrc(String login_qrc) {
        this.login_qrc = login_qrc;
    }

    public String getSenha_qrc() {
        return senha_qrc;
    }

    public void setSenha_qrc(String senha_qrc) {
        this.senha_qrc = senha_qrc;
    }

    public String getDthr_qrc() {
        return dthr_qrc;
    }

    public void setDthr_qrc(String dthr_qrc) {
        this.dthr_qrc = dthr_qrc;
    }

    public int getAtivo_qrc() {
        return ativo_qrc;
    }

    public void setAtivo_qrc(int ativo_qrc) {
        this.ativo_qrc = ativo_qrc;
    }}
