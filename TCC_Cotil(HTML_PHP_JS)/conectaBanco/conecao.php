<?php

define('HOST', '143.106.241.3');
define('USUARIO', 'cl18483');
define('SENHA', 'cl*03072002');
define('DB', 'cl18483');

$conecao = mysqli_connect(HOST, USUARIO, SENHA, DB) or die ('Não conectou parça');

?>