<?php
include 'dbconnect.php';

$sql = "SELECT nome FROM equipa";
$result = $conn->query($sql);

// Create an array to store the team names
$nomes = array();
if ($result->num_rows > 0) {
  while($row = $result->fetch_assoc()) {
    $nomes[] = $row["nome"];
  }
}
$conn->close();
?>

<html>
<head>
	<title>Inserir Jogo</title>
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
	<h1>Inserir Jogo</h1>
  <form method="post" action="">
    <label for="team">Equipa 1:</label>
    <select id="team" name="team">
      <?php foreach ($nomes as $nome) { ?>
        <option value="<?php echo $nome; ?>"><?php echo $nome; ?></option>
      <?php } ?>
    </select>
    <label for="team">Equipa 2:</label>
    <select id="team2" name="team2">
      <?php foreach ($nomes as $nome) { ?>
        <option value="<?php echo $nome; ?>"><?php echo $nome; ?></option>
      <?php } ?>
    </select><br>
    <label for="golos">Golos:</label>
    <input type="number" name="golos" id="golos">
    <input type="number" name="golos" id="golos">
    <br>
    <input type="submit" value="CONFIRMAR" style="height:30px; width:100px; border-radius: 30px">
  </form>
</body>
</html>
