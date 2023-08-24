<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<title>Produtos</title>
	<link rel="icon" href="images/logoIcon.ico">
  	<meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
	<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous">
  	<link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.3.1/css/all.css" integrity="sha384-mzrmE5qonljUremFsqc01SB46JvROS7bZs3IO2EmfFsd15uHvIt+Y8vEf7N7fWAU" crossorigin="anonymous">
  	<link href="https://fonts.googleapis.com/css?family=Racing+Sans+One&display=swap" rel="stylesheet">
  	<link rel="stylesheet" type="text/css" href="css/style.css">
	<link rel="stylesheet" type="text/css" href="css/font.css">
</head>
<body>
<?php 
  session_start();
?>
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
          <a class="dropdown-item" href="Notebooks.html">Notebooks</a>
          <a class="dropdown-item" href="PCs.html">PCs</a>
          <a class="dropdown-item" href="Acessórios.html">Acessórios</a>
          <a class="dropdown-item" href="Headsets.html">Headsets</a>
        </div>
      </li>
      <li class="nav-item">
        <a class="nav-link active" href="sobre.html">Sobre</a>
      </li>
      <li class="nav-item">
        <a class="nav-link active" href="contato.html">Contatos</a>
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
</nav>

<!-- PRODUTOS -->

<!---Pesquisar-->
<p style="text-align: center;" id="title">PRODUTOS</p>
<br>
<div style="margin-left: 38%">
<div class="col-md-12 col-sm-12" id="pesquisar">

    <form class="form-inline my-2 my-lg-0" class="search">
      <input  class="form-control mr-sm-2" type="search" placeholder="Pesquisar" aria-label="Pesquisar" style="text-align: center;">
      <button class="btn my-4 my-sm-0" type="submit">Pesquisar</button>
    </form>
  </div></div>

<br><br>

<div class="container">
	<div class="row">
	            

	            <div id="div" class="col-md-3 col-sm-10">
	            	<h2 align="center">Fotos</h2>
	              <div class="card mb-3" align="center">	               
	                 <div class="card-body">
	                  <img class="card-img-top" src="images\produtos\prod2.jpg" alt="Card image cap">
	                 </div>
	              </div>
	              <div class="card mb-3" align="center">	               
	                 <div class="card-body">
	                  <img class="card-img-top" src="images\produtos\prod2.jpg" alt="Card image cap">
	                 </div>
	              </div>
	              <div class="card mb-3" align="center">	               
	                 <div class="card-body">
	                  <img class="card-img-top" src="images\produtos\prod2.jpg" alt="Card image cap">
	                 </div>
	              </div>
	              
	            </div>

	          
              <?php

              ?>
	            <div class="col-md-6 col-sm-12">
	            	<h3 align="center">Notebook Dell Inspiron I15-7572-A30S Intel Core 8ª i7 16GB (GeForce MX150 com 4GB) 1TB 128GB SSD Tela Full HD 15,6″ Windows 10 – Prata</h3>
                <form action="buscaBanco.php" method="POST">
	            	<div class="card-body col-md-12">
	                  <img class="card-img-top" src="images\produtos\prod2.jpg" alt="Card image cap">
	                 </div></form>

	            	<h3 align="center">12X De 155,50 ou Á Vista 1860,00</h3>
<br><br>
<form action="mudarBanco.php" method="POST">
                <div align="center">
	            	<button id="btn" class="btn my-4 my-sm-0" type="submit">Finalizar Compra</button>
	            	</div></form>
	            	
	            
	            </div>

	            

	</div>
</div>

<br><br><br><br>
<footer>
<nav class="navbar navbar-dark">
	<p>
       <b>Monasilli Tech Store LTDA.</b><br>
    </p>
</nav>
</footer>

<script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49" crossorigin="anonymous"></script>
<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js" integrity="sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy" crossorigin="anonymous"></script>
</body>
</html>