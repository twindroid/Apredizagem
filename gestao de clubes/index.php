<html>
<head>
	<title>Pontuação</title>
</head>
<body>
<nav>
  <ul>
    <li><a href="index.php">Inicio</a></li>
    <li><a href="inserirequipas.php">Inserir Equipa</a></li>
    <li><a href="inserirjogo.php">Inserir Jogo</a></li>
  </ul>
</nav>
<style>
		body {
			margin: 0;
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
			justify-content: space-between;
			align-items: center;
			max-width: 960px;
			margin: 0 auto;
			padding: 0 20px;
			height: 80px;
		}
		nav a {
			color: white;
			text-align: center;
			padding: 0 16px;
			text-decoration: none;
			font-size: 20px;
			line-height: 80px;
			transition: all 0.3s ease-in-out;
		}
		nav a:hover {
			background-color: #ddd;
			color: black;
		}
		h1 {
			text-align: center;
			font-size: 36px;
			margin: 40px 0 20px 0;
		}
		table {
			border-collapse: collapse;
			width: 100%;
			max-width: 960px;
			margin: 0 auto;
			background-color: white;
			box-shadow: 0px 0px 10px 2px rgba(0,0,0,0.1);
			border-radius: 10px;
			overflow: hidden;
			margin-bottom: 40px;
		}
		th, td {
			padding: 12px 15px;
			text-align: left;
			border-bottom: 1px solid #ddd;
			font-size: 18px;
		}
		th {
			background-color: #333;
			color: white;
		}
		tr:hover {
			background-color: #f5f5f5;
		}
	</style>
	<h1>Pontuação</h1>
	<table>
	  <tr>
	    <th>Nome</th>
	    <th>Golos</th>
	    <th>Vitórias</th>
	    <th>Derrotas</th>
	    <th>Empates</th>
	    <th>Jogos</th>
	    <th>Golos S</th>
	    <th>Jogadores</th>
	  </tr>

	  <?php
	  include 'dbconnect.php';
	  $sql = "SELECT * FROM equipa";
	  $result = $conn->query($sql);

	  if ($result->num_rows > 0) {
	    while($row = $result->fetch_assoc()) {
	      echo "<tr>";
	      echo "<td>" . $row["nome"] . "</td>";
	      echo "<td>" . $row["golos"] . "</td>";
	      echo "<td>" . $row["vitorias"] . "</td>";
	      echo "<td>" . $row["derrotas"] . "</td>";
	      echo "<td>" . $row["empates"] . "</td>";
	      echo "<td>" . $row["jogos"] . "</td>";
	      echo "<td>" . $row["golos_s"] . "</td>";
	      echo "<td>" . $row["jogadores"] . "</td>";
	      echo "</tr>";
	    }
	  } else {
	    echo "0 resultados";
	  }
	  $conn->close();
	  ?>

	</table>
</body>
</html>

<?php
if ($_SERVER["REQUEST_METHOD"] == "POST") {
  // Get data from form
  $nome = $_POST["nome"];
  $jogadores = $_POST["jogadores"];

  include 'dbconnect.php';
// Execute SQL query to get the list of teams
$sql = "SELECT * FROM equipa";
$result = $conn->query($sql);

// Create an array to store the team names
$teams = array();
if ($result->num_rows > 0) {
  while($row = $result->fetch_assoc()) {
    $teams[] = $row["nome"];
  }
}

$conn->close();
 
}
?>