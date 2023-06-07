<template>
  <div class="container mt-3">
    <h3>Cadastro de Categoria</h3>
    <form class="row g-3">

<div class="col-md-2">
 <label  class="form-label">Code</label>
 <input type="text" class="form-control" id="code" name="code" placeholder="Digite o Codigo" aria-label="Digite o Codigo">
</div>

<div class="col-md-4">
 <label  class="form-label">Categoria</label>
 <input type="text" class="form-control" id="name" name="name" placeholder="Digite o nome da Categoria" aria-label="Digite o nome da Categoria">
</div>

<div class="col-12">
  <button v-on:click="salvar()" type="submit" class="btn btn-primary">Salvar</button>
</div>

</form>
</div>
</template>

<script>
import axios from 'axios';

export default {
    name: "CadastroCategoria",
    props: {
    msg: String
  }, 
  data:() => {
  return {
    Category:[],
      Categorys: undefined,
      category: "",
      
    }
  },
  methods:{
    salvar () {
      if(this.category){
        console.log(res)
        return
      }
      
      axios.post('https://localhost:7172/api/Category',
      {
        code:document.getElementById("code").value,
        name:document.getElementById("name").value,
      }).then(()=>{
        console.log(res)
        
      })
      
    },

    
  },
    
  }
</script>