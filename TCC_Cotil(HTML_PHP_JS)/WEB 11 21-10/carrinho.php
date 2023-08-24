<?php 

//require "verifica.php"; 
require "conecao.php";

?>

<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
  <link rel="icon" href="images/logoIcon.ico">
  <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
  <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous">
  <link href="https://fonts.googleapis.com/css?family=Racing+Sans+One&display=swap" rel="stylesheet">
  <link rel="stylesheet" type="text/css" href="css/style.css">
  <link rel="stylesheet" type="text/css" href="css/font.css">
  <title>Carrinho</title>
</head>

<body>

<nav class="navbar navbar-expand-lg navbar-dark">

   <a href="index.html" class="navbar-brand">
          <img src="images/LogoM.png" style="width: 200px; height: auto;" class="d-inline-block align-middle">
        </a>
    <!--<a class="navbar-brand" href="index.html" id="Logo" style="background-color: #f19c67" >Monassili Tech Store</a>-->


  <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#conteudoNavbarSuportado" aria-controls="conteudoNavbarSuportado" aria-expanded="false" aria-label="Alterna navegação">
    <span class="navbar-toggler-icon"></span>
  </button>


  <div class="collapse navbar-collapse" id="conteudoNavbarSuportado">
    <ul class="navbar-nav mr-auto">
      <li class="nav-item active">
        <a class="nav-link" href="index.html">Home<span class="sr-only">(página atual)</span></a>
      </li>

      <li class="nav-item dropdown">
        <a class="nav-link dropdown-toggle active" id="navbarDropdown" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
          Produtos
        </a>

        <div class="dropdown-menu" aria-labelledby="navbarDropdown">
          <a class="dropdown-item" href="produtos.html">Notebooks</a>
          <a class="dropdown-item" href="produtos.html">PCs</a>
          <a class="dropdown-item" href="produtos.html">Acessórios</a>
          <a class="dropdown-item" href="produtos.html">Headsets</a>
        </div>
      </li>
      <li class="nav-item">
        <a class="nav-link active" href="sobre.html">Sobre</a>
      </li>
      <li class="nav-item">
        <a class="nav-link active" href="contatos.html">Contatos</a>
      </li>
    </ul>
    
    </div>

  <!---Bem-Vindo-->
    <div class="col-md-2 col-sm-12" >

               <div class="card mb-1" align="center">
                <h2 class="card-title">Bem Vindo!</h2>
                  <h6 class="card-subtitle mb-1"></h6>
                 <a href="login.html" class="btn">Login</a><a href="cadastro.html" class="btn">Cadastro</a>
                </div>
                </div> 
              </div></ul>
<br><br></nav>

  <!-- PRODUTOS -->
  <h1 style="color: purple; text-align: center; font-size: 500%">Bem Vindo!</h1>

  <p style="text-align: center;" id="title">CARRINHO</p>





  <hr>
   <p>
    <div class="container" align="center">
      <div class="jumbotron jumbotron-fluid">
        <fieldset> 

        </fieldset>

  </div>
  <button  type="submit" class="btn btn-primary">Finalizar Compra</button>
</div></p>

<form action="sair.php" style="margin-left: 48.5%">
  
     <button  type="submit" class="btn btn-primary">Sair</button>

</form>



<footer style="margin-left: -30%">
<nav class="navbar navbar-dark">
  <p >
       <b>Monasilli Tech Store LTDA.</b>
    </p>
</nav>
</footer>

<script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49" crossorigin="anonymous"></script>
<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js" integrity="sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy" crossorigin="anonymous"></script>
</body>
</html>