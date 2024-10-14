<?php
$servername = "localhost";
$username = "root";
$password = "";
$dbname = "vnf20736";

// Create connection
$conn = new mysqli($servername, $username, $password, $dbname);

// Check connection
if ($conn->connect_error) {
  die("Erro: " . $conn->connect_error);
}
echo "Está ligado à base de dados";
?>