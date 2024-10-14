<!DOCTYPE html>
<html>
<head>
	<title>Nova equipa</title>
</head>
<body>
	<h1>Inserir equipa</h1>

	<form action="<?php echo ($_SERVER["REQUEST_METHOD"]); ?>" method="post">
		<label for="nome">Nome da equipe:</label><br>
		<input type="text" id="nome" name="nome"><br><br>

		<label for="jogadores">Jogadores:</label><br>
		<input type="int" id="jogadores" name="jogadores"><br><br>

		<input type="submit" value="Inserir">
	</form>
</body>
</html>

<?php
if ($_SERVER["REQUEST_METHOD"] == "post") {
  // Get data from form
  $nome = $_POST["nome"];
  $jogadores = $_POST["jogadores"];

  // Connect to database
  $servername = "localhost";
  $username = "username";
  $password = "password";
  $dbname = "myDB";
  $conn = new mysqli($servername, $username, $password, $dbname);

  // Check connection
  if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
  }

  // Prepare and execute SQL query
  $stmt = $conn->prepare("INSERT INTO equipa (nome, jogadores) VALUES (?, ?)");
  $stmt->bind_param("si", $nome, $jogadores);

  if ($stmt->execute() === TRUE) {
    echo "Equipa inserida com sucesso!";
  } else {
    echo "Erro ao inserir equipe: " . $conn->error;
  }
  $conn->close();
}
?>