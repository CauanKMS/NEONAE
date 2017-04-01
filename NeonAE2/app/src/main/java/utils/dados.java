package utils;

abstract public class dados {

    private static int idUsuario;
    private static String login;
    private static String senha;
    private static String hr;

    public static String getLogin() {
        return login;
    }

    public static void setLogin(String login) {
        dados.login = login;
    }

    public static String getSenha() {
        return senha;
    }

    public static void setSenha(String senha) {
        dados.senha = senha;
    }

    public static int getIdUsuario() {
        return idUsuario;
    }

    public static void setIdUsuario(int idUsuario) {
        dados.idUsuario = idUsuario;
    }

    public static String getHr() {
        return hr;
    }

    public static void setHr(String hr) {
        dados.hr = hr;
    }

}
