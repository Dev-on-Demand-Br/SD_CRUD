<template>
  <div class="container mt-3">
    <h3>Cadastro de Produtos</h3>

  <form class="row g-3">

    <div class="col-md-2">
     <label  class="form-label">Sku</label>
     <input type="text" class="form-control" id="sku" name="sku" placeholder="Digite o Sku" aria-label="Digite o Sku">
    </div>

   <div class="col-md-4">
     <label  class="form-label">Produto</label>
     <input type="text" class="form-control" id="name" name="name" placeholder="Digite o nome do Produto" aria-label="Digite o nome do Produto">
    </div>

    <div class="col-md-2">
     <label  class="form-label">Categoria</label>
     <select id="category" name="category" class="form-select">
        <option selected>Sem Categoria</option>
        <option>{{category}}</option>
        <option>{{category}}</option>
        <option>{{category}}</option>
     </select>
   </div>

    <div class="col-md-2">
     <label  class="form-label">Preço</label>
      <input type="number" class="form-control" id="price" name="price" placeholder="Digite o Valor do Produto" aria-label="Digite o Valor do Produto">
    </div>

    <div class="col-md-2">
     <label  class="form-label">Quantidade</label>
      <input type="number" class="form-control" id="stock" name="stock" placeholder="Qtd" aria-label="Qtd">
    </div>

    <div class="col-12">
      <label class="form-label">Descrição</label>
      <!-- <input type="text" class="form-control" id="description" name="description" placeholder="Descrição do Produto"> -->
      <textarea type="text" class="form-control" id="description" name="description" placeholder="Descrição do Produto"></textarea>
    </div>
    
    <div class="col-12">
      <button v-on:click="salvar()" type="submit" class="btn btn-primary">Salvar</button>
    </div>
  </form>
<hr>

<table class="table">
      <thead>
        <tr>
          <th>
            Sku
          </th>
          <th>
            Produto
          </th>
          <th>
            Preço
          </th>
          <th>
            Descrição
          </th>
          <th>
            Categoria
          </th>
          <th colspan="2"></th>
        </tr>
      </thead>

      <tbody>
        <tr v-for="Products in Product" v-bind:key="Products.Id">
          <td>
            {{Products.sku}}
          </td>
          <td>
            {{Products.name}}
          </td> 
          <td>
            {{Products.description}}
          </td>
          <td>
            {{Products.price}}
          </td>
          <td>
            {{Products.category}}
          </td>
          <td>
            <button class="btn btn-primary" v-on:click="editar(Products)">Editar</button>
          </td>
          <td>
            <button class="btn btn-danger" v-on:click="excluir(Products.id)">Excluir</button>
          </td>
        </tr>
      </tbody>

    </table>


  </div>

</template>

<script>
import axios from 'axios';

export default {
  name: 'CadastroProduto',
  props: {
    msg: String
  },

  data:() => {
    return {
      Product:[],
      Products: undefined,
      mensagem: "",
    }
  },
  methods:{
    //Lista os Produtos na tela
    lista () {
      axios.get('https://localhost:7172/api/Product').then((res)=>{
       console.log(res) 
       this.Product = res.data
      })
    },
    salvar () {
      if(this.Products){
        this.alterar()
        return
      }
      
      axios.post('https://localhost:7172/api/Product',
      {
        sku:document.getElementById("sku").value,
        name:document.getElementById("name").value,
        category:document.getElementById("category").value,
        description:document.getElementById("description").value,
        price:document.getElementById("price").value
      }).then(()=>{
        console.log(res)
        this.lista()
      })
    },


  }
}
</script>



<style>

</style>
