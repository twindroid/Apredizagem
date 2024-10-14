<?php 
if ($_SERVER["REQUEST_METHOD"] == "POST") {
  // Get data from form
  $nome = $_POST["nome"];
  $jogadores = $_POST["jogadores"];

 include 'dbconnect.php';

  // Prepare and execute SQL query
  $stmt = $conn->prepare("INSERT INTO equipa (nome, jogadores) VALUES (?, ?)");
  $stmt->bind_param("si", $nome, $jogadores);

  if ($stmt->execute() === TRUE) {
    echo "Equipa inserida com sucesso!";
  } else {
    echo "Erro ao inserir equipa: " . $conn->error;
  }
  $conn->close();
}
?>


<html>
<head>
	<title>Nova equipa</title>
  <nav>
  <ul>
  <li><a href="index.php">Inicio</a></li>
  <li><a href="inserirequipas.php">Inserir Equipa</a></li>
  <li><a href="inserirjogo.php">Inserir Jogo</a></li>
  </ul>
</nav>
<style>
    body {
      font-family: Arial, sans-serif;
      background-color: #f2f2f2;
    }

    nav {
      background-color: #333;
      overflow: hidden;
    }

    nav ul {
      margin: 0;
      padding: 0;
      list-style: none;
      display: flex;
    }

    nav li {
      margin: 0;
      padding: 0;
    }

    nav a {
      display: block;
      color: white;
      text-align: center;
      padding: 14px 16px;
      text-decoration: none;
    }

    nav a:hover {
      background-color: #ddd;
      color: black;
    }

    h1 {
      margin-top: 50px;
      text-align: center;
    }

    form {
      max-width: 500px;
      margin: 0 auto;
      background-color: white;
      padding: 20px;
      border-radius: 5px;
      box-shadow: 0px 2px 5px rgba(0, 0, 0, 0.3);
    }

    label {
      display: block;
      font-weight: bold;
      margin-bottom: 5px;
    }

    input[type="text"],
    input[type="number"] {
      width: 100%;
      padding: 10px;
      margin-bottom: 20px;
      border: 1px solid #ccc;
      border-radius: 4px;
      box-sizing: border-box;
      font-size: 16px;
    }

    input[type="submit"] {
      background-color: #333;
      color: white;
      padding: 10px 20px;
      border: none;
      border-radius: 4px;
      cursor: pointer;
      font-size: 16px;
    }

    input[type="submit"]:hover {
      background-color: #ddd;
      color: black;
    }
  </style>
</head>
<body>
	<h1>Inserir equipa</h1>

  <form action="inserirequipas.php" method="POST">
		<label for="nome">Nome da equipa:</label><br>
		<input type="text" id="nome" name="nome"><br><br>

		<label for="jogadores">Jogadores:</label><br>
		<input type="int" id="jogadores" name="jogadores"><br><br>

		<input type="submit" value="Inserir">
	</form>
</body>
</html>