package app;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;

public class Conta {

	private int id;

	private String nome;

	private double saldo;

	private String senha;

	public void setId(int id) {

		this.id = id;

	}

	public int getId() {

		return id;

	}

	public void setNome(String nome) {

		this.nome = nome;

	}

	public String getNome() {

		return nome;

	}

	public void setSaldo(double saldo) {

		this.saldo = saldo;

	}

	public double getSaldo() {

		return saldo;

	}
	public String getSenha() {
		return senha;
	}

	public void setSenha(String senha) {
		this.senha = senha;
	}

	public boolean saque(double quantia) {
		System.out.println("Dentro do método saque()");
		if (this.getSaldo() >= quantia && quantia>0) {

			Connection con = null;

			PreparedStatement stmt = null;


			try {

				con = this.getConexao();

				stmt = con.prepareStatement("UPDATE conta SET saldo=? WHERE idconta = ?");

				stmt.setDouble(1, this.getSaldo()-quantia);
				stmt.setInt(2, this.getId());

				stmt.executeUpdate();

				con.close();
				return true;
			} catch (Exception e) {

				System.out.println("Erro no método saque: " + e.getMessage());

				e.printStackTrace();
				return false;
			}

		} else {
			return false;
		}
	}

	public boolean deposito(double quantia) {
		if (quantia>0) {
			System.out.println("Dentro do método deposito()");

			Connection con = null;

			PreparedStatement stmt = null;


			try {

				con = this.getConexao();

				stmt = con.prepareStatement("UPDATE conta SET saldo=? WHERE idconta = ?");

				stmt.setDouble(1, this.getSaldo()+quantia);
				stmt.setInt(2, this.getId());

				stmt.executeUpdate();

				con.close();


			} catch (Exception e) {

				System.out.println("Erro no método deposito: " + e.getMessage());

				e.printStackTrace();

			}
			return true;
		}else {
			return false;
		}
	}

	public boolean recuperar() {

		System.out.println("Dentro do método recuperar()");

		boolean resultado = false;

		Connection con = null;

		PreparedStatement stmt = null;

		ResultSet rs = null;

		try {

			con = this.getConexao();

			stmt = con.prepareStatement("SELECT * FROM conta WHERE idconta = ?");

			stmt.setInt(1, this.getId());

			rs = stmt.executeQuery();

			if (rs.next()) {

				this.setNome(rs.getString("nome"));

				this.setSaldo(rs.getDouble("saldo"));

				this.setSenha(rs.getString("senha"));

				resultado = true;

			}

			con.close();

		} catch (Exception e) {

			System.out.println("Erro no método saque: " + e.getMessage());

			e.printStackTrace();

		}

		return resultado;

	}
	public boolean abrirConta() {

		System.out.println("Dentro do método abrirConta()");

		boolean resultado = false;

		Connection con = null;

		PreparedStatement stmt = null;

		try {

			con = this.getConexao();

			stmt = con.prepareStatement("Insert into conta(nome,saldo,senha) values(?,?,?);");


			stmt.setString(1, this.getNome());
			stmt.setDouble(2, 0.00);
			stmt.setString(3, this.getSenha());

			stmt.executeUpdate();
			resultado=true;

			con.close();

		} catch (Exception e) {

			System.out.println("Erro no método abrirConta: " + e.getMessage());

			e.printStackTrace();

		}

		return resultado;

	}

	private Connection getConexao() {

		Connection con = null;

		try {

			String url = "jdbc:postgresql://localhost:5432/dbbanco";

			String usuario = "postgres";

			String senha = "postgres";

			Class.forName("org.postgresql.Driver");

			con = DriverManager.getConnection(url, usuario, senha);

			System.out.println("Conexão realizada com sucesso.");

		} catch (Exception e) {

			System.out.println("Falha conexão: " + e.getMessage());

		}

		return con;

	}
}
