<?php

require "conecao2.php"; 

session_start(); 
 
 //$conexao->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);

 $comandoSQL2  = $conexao->prepare("SELECT Imagem From Produtos WHERE Id='23'");

 $comandoSQL2->execute();

 
//$result = mysqli_query("SELECT Imagem From Produtos WHERE Id='23'") or die('Deu ruim parça');
//$row = mysqli_fetch_array($result);

//header("Content-type: image/jpeg"); echo $row['imageContent'];
 
if (isset($_GET['Id'])) {
	$query = mysql_query("SELECT Imagem From Produtos WHERE Id='23'");
	while ($row = mysql_fetch_assoc($query)) {
		
		$imageData = $row["image"];

	}
	header("Content-type: image/jpeg");
	echo $imageData;
}else{

	echo ("deu ruim");

}

 $comandoSQL2  = $conexao->prepare("SELECT Imagem From Produtos WHERE Id='23'");

 $comandoSQL2->execute();

 
$result = mysqli_query("SELECT Imagem From Produtos WHERE Id='23'") or die('Deu ruim parça');
$row = mysqli_fetch_array($result);

header("Content-type: image/jpeg"); echo $row['imageContent'];
 

	$query = mysqli_query("SELECT Imagem From Produtos WHERE Id='23'");
	while ($row = mysqli_fetch_assoc($query)) {
		
		$imageData = $row["image"];

	}
	header("Content-type: image/jpg");


	echo $imageData;




?>