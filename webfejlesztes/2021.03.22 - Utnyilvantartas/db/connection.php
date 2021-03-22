<?php
/**
 * Created by PhpStorm.
 * User: redy
 * Date: 22.03.2021
 * Time: 19:45
 */

$servername = "localhost";
$username = "root";
$password = "";
$dbname = "utnyilvantartas";

// Create connection
$conn = new mysqli($servername, $username, $password, $dbname);
// Check connection
if ($conn->connect_error) {
    die("Kapcsolati hiba: " . $conn->connect_error);
}

