3<?php
//conecao do BD PDO

$conexao = new PDO("mysql:host=143.106.241.3;dbname=cl18483","cl18483","cl*03072002");

// host = ip do serve, barreto=usaário, senha=senha

//ativar o depurador de erros do PDO

$conexao->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);

$comandoSQL = $conexao-> query(
"SELECT * FROM usuario");

$arrayStringJson = array();

while ($linha = $comandoSQL->fetch()) {
	$arrayStringJson[] = $linha;
}

$arrayJson = json_encode($arrayStringJson, JSON_UNESCAPED_SLASHES | JSON_UNESCAPED_UNICODE);

echo $arrayJson;

?>