<template>
    <div class="container">
        <div class="card">
            <div class="card-body">
                <h1>Sign Up</h1>
                <p>Preencha o formulario para criar sua conta.</p>
                <hr>

                <label for="username"><b>Username</b></label>
                <input v-model="user.username" ref="username" type="text" placeholder="Username" name="username"> 

                <label for="email"><b>Email</b></label>
                <input v-model="user.email" ref="email" type="text" placeholder="Digite o Email" name="email"> 

                <label for="psw"><b>Senha</b></label>
                <input v-model="user.password" ref="password" type="password" placeholder="Digite a Senha" name="psw"> 

                <label for="psw-repeat"><b>Repita a senha</b></label>
                <input v-model="user.repeatPassword" ref="password" type="password" placeholder="Username" name="username"> 

                <label>
                    <input type="checkbox" checked="checked" name="remember" style="margin-bottom:15px"> Lembre-me
                </label>

                <p>Ao criar a conta você aceita os <a href="#" style="color:dodgerblue"> Temos & Privacidade</a>.</p>

                <div class="clearfix">
                    <button type="button" class="cancelbtn" v-on:click="back">Cancelar</button>
                    <button type="submit" class="signupbtn" v-on:click="signup">Criar</button>
                </div>
            </div>
        </div>
    </div>
</template>

<script>
import axios from "axios"
import Swal from 'sweetalert2'


export default ({
    data(){
        return {
            user:{
                userId: 0,
                username:"",
                email:"",
                password:"",
                repeatPassword:""
            },
        }
    },
    methods:{
        back(){
            this.$router.push({ name: 'Login'});

        },
        signup(){
            if(this.checkValidation()){
                axios.post(this.hostname + "/api/user/registration", this.user)
                .then(response =>{
                    if (response.data.userId > 0){
                        Swal.fire("Successfully resgistered")
                        .then(() => {
                            this.back();
                        });
                    } else{
                        Swal.fire("Erro : Something went wrong");
                    }
                })
                .catch(error => {
                    if (error.response){
                        Swal.fire(error.response.data);
                    }
                });
            }
        },


        checkValidation(){
            if(!this.user.username){
                this.$refs.username.focus();
                Swal.fire("Give username !");
                return;
            }
            if(!this.user.email){
                this.$refs.email.focus();
                Swal.fire("Give Email !");
                return;
            }if(!(/\w+([-+.']\w+)*@\w+([-.]\w+)*\.w+([-.]\w+)*/).test(this.user.email)){
                this.$refs.email.focus();
                Swal.fire("Invalid email !");
                return;
            }
            if(!this.user.password){
                this.$refs.password.focus();
                Swal.fire("Give Password !");
                return;
            }
            if(this.user.password != this.user.repeatPassword){
                this.$refs.psw.focus();
                Swal.fire("Passwor and repeat password mismatched !");
                return;
            }
            return true;
        },
    }


})
</script>

<style>
.container{
    width: 40%;
    padding: 16px;
}
</style>