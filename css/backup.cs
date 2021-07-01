/* FONTS*/
@font-face {
    font-family: "Mark Pro Medium" ;
    src: url(fonts/FontFont\ -\ Mark\ Pro\ Medium.otf) format("open type");
}

@font-face {
    font-family: "Mark Pro Bold";
    src: url(fonts/FontFont\ -\ Mark\ Pro\ Bold.otf) format("otf");
}

*{
    margin: 0;
    padding: 0;
}


/* ENCABEZADOS*/
.headline-container{
    display: flex;
    justify-content: space-around;

}
h1{
/* PROPIEDADES DE TEXTO*/
width: 1080px;
display: flex;
justify-content: center;
align-items: center;
color: rgb(255, 255, 255);
font-size: 75px;
letter-spacing: normal;
line-height: normal;
text-transform: capitalize;
word-spacing: normal;
font-family: "Mark Pro Medium";
animation-duration: 2s;
animation-name: aparecer;
padding: 20px;
}

@keyframes aparecer {

    0% {
        opacity: 0;
    }
    100%{
        opacity: 1;
    }
}


/*HEADER*/

.Header{

display: flex;
flex-wrap: wrap;

}

.HeaderMenu{
width: 3840px;
display: flex;
justify-content: space-around;
align-items: center;
padding: 50px;
margin-left: auto;
margin-right: auto;
}


.link{
color:rgb(255, 255, 255);
font-family: "Mark Pro Medium";
font-size: 1em;
text-decoration: none;
margin-left:10px ;
margin-right:10px ;
transition-property: all;
transition-duration: 2s
}

.link:hover{
transform: translateY(-12px);
color:rgb(167, 16, 109);
font-family: "Mark Pro Medium";
font-size: 1em;
text-decoration: none;

}

/*BOTONES*/
.Boton{
width: 50px;

}
.link2{
color:rgb(255, 255, 255);
font-family: "Mark Pro Medium";
font-size: 1em;
text-decoration: none;
transition-property: all;
transition-duration: 2s
}

.link2:hover{
transform: scale(1.2);
font-family: "Mark Pro Medium";
font-size: 1em;
text-decoration: none;
}

.align1{
 display: inline;
 padding: 350px;
}

/*FOOTER*/
.footer-container{
    display: flex;
    justify-content: center;
}
.alignfooter {
display: flex;
justify-content:space-around;
align-items: center;
padding: 120px;
}


.Footer1{
    width: 30px;
}
.Footer2 {
    width: 30px;
}
.Footer3 {
    width: 30px;   
}




padding: 120px;


}


/*Cerveza*/
.Birra{
    display: flex;
    justify-content:space-around;
    padding: 90px;
    transform: rotateZ(360deg);
    transition-duration: 180s;
}



.Beer{
width: 100%;
transition-property: all;
transition-duration: 2s ;

}

.Beer:hover{
    transform: scale(1.2);
}

.Beer2{
width: 100%;
transition-property: all;
transition-duration: 2s ;

}

.Beer2:hover{
    transform: scale(1.2);


}

.Beer3{
width: 130%;
transition-property: all;
transition-duration: 2s ;
}

.Beer3:hover{
    transform: scale(1.2);

}


/*HONEY*/
/*PROPIEDADES DE TEXTO*/

.menu-container{
    display: flex;
    justify-content: center;
}
.menu{
    width: 1080px;
    display: flex;
    justify-content: space-around;
    padding: 50px;
    align-items: center;
}
.container-paragraph{
    display: flex;
    justify-content: center;

}
.style-paragraph-honey {
    width: 1080px;
    color: rgb(255, 255, 255);
    font-size: 16px;
    font-family: "Mark Pro Medium";
    letter-spacing: normal;
    line-height: normal;
    text-align: center;
    word-spacing: normal;
    display: flex;
    justify-content: center;
    align-items: center;
    margin-left: 200px;
    margin-right: 200px;
   
    
    
}


.VH {
    position: absolute;
    top: 0;
    left: 0;
    z-index: -1;
    width: 1020%;

}

/*WOLFIPA*/
/*PROPIEDADES DE TEXTO*/

.style-paragraph-wolfipa{
    color: rgb(255, 255, 255);
    font-size: 1em;
    font-family: "Mark Pro Medium";
    letter-spacing: normal;
    line-height: normal;
    text-align: center;
    word-spacing: normal;
    display: flex;
    justify-content: center;
    align-items: center;
    margin-left: 200px;
    margin-right: 200px;
}
.style-paragraph-wolfipa::first-letter{
    color:rgb(167, 16, 109);
}

.videoc-container{
    
}
.VWI{
    
    position: absolute;
    top: 0;
    left: 0;
    z-index: -1;
    display: grid
}
.video{
    width: 200%;
}

/* SCOTTISH*/
/*PROPIEDADES DE TEXTO*/
.style-paragraph-scottish{
    color: rgb(255, 255, 255);
    font-size: 1em;
    font-family: "Mark Pro Medium";
    letter-spacing: normal;
    line-height: normal;
    text-align: center;
    word-spacing: normal;
    display: flex;
    justify-content: center;
    align-items: center;
    margin-left: 200px;
    margin-right: 200px;
}

.VS{
    position: absolute;
    top: 0;
    left: 0;
    z-index: -1;
    size: cover;
}

/*BREWERY*/
/*PROPIEDADES DE TEXTO*/


p{
    color: rgb(185, 185, 185);
    font-size: 14px;
    font-family: "Mark Pro Medium";
}

h2{
    color: rgb(255, 255, 255);
    font-size: 24px;
    font-family: "Mark Pro Medium";

}


.bordes{

display: flex;
justify-content: center;
color: #fff;
}
.table{
    color: rgb(255, 255, 255);
    font-size: 1em;
    font-family: "Mark Pro Medium";
    letter-spacing: normal;
    line-height: normal;
    text-align: center;
    word-spacing: normal;
    padding: 30px;
    position: center;
    border-style: solid;
    
}

.BreweryF{
    background-image: linear-gradient(to bottom,black, rgb(21, 95, 95));
    position: relative;
}
.BG{
    position: absolute;
    top: 0;
    left: 0;
    z-index: -1;
   
    width: 400%;
    opacity: 0.4;
}

/* CONTACTO*/
/*PROPIEDADES DE TEXTO*/

.contact{
    position: relative;
    min-height: 100vh;
    padding: 50px 100px;
    display: flex;
    justify-content: center;
    align-items: center;
    flex-direction: column;

}
.contact .content {

    max-width: 800px;
    text-align: center;

}

.contact .content h2 {
    font-size: 36px;
    font-weight: 500;
    color: rgb(250, 250, 250);


}

.contact .content p {
    font-size: 16px;
    font-weight: 500;
    color: rgb(156, 156, 156);


}

.container{
    width: 100%;
    display: flex;
    justify-content: center;
    align-items: center;
    margin-top: 30px;

}

.container .contactinfo {

    width: 50%;
    display: flex;
    flex-direction: column;

}

.container .contactinfo .box {
    position: relative;
    padding: 20px 0;
    display:flex;
    color: rgb(255, 255, 255);
}
.container .contactinfo .box .icon {
    min-width: 60 px;
    height: 60 px;
    background: #fff;
}

.contactform{
    width: 40%;
    padding: 40px;
    background:  #fff;
}

.contactform{
    font-size: 30px;
    color:#333;
    font-weight:500;
}

.contactform .inputbox {
    position: relative;
    width: 100%;
    margin-top: 10px;

}

.contactform .inputbox input,
.contactform .inputbox textarea {
    width: 100%;
    padding:5px 0;
    font-size: 13px;
    margin: 10px 0;
    border: none;
    border-bottom: 2px solid #333;
    outline:none ;
    resize: none;

}

.contact .inputbox span {
    position: absolute;
    left: 0;
    padding:5px 0;
    font-size: 13px;
    margin: 10px 0;
    pointer-events: none;
    transition: 0.5s;
    color: #666;
}

.contactform .inputbox input:focus ~ span,
.contactform .inputbox input:valid ~ span,
.contactform .inputbox textarea:focus ~ span,
.contactform .inputbox textarea:valid ~ span 
{
    color: rebeccapurple;
    font-size: 12px;
    transform: translate(-20px);
}

.contactform .inputbox input[
    type="submit"]
    {width: 100px;
        background-color: rgb(144, 231, 224);
        color: #fff;
        border: none;
        cursor: pointer;
        padding: 18px;
    }

.mapcontainer{
    display: flex;
    justify-content: center;
}

.map{
    display: flex;
    justify-content: center;
}
    
.VS{
    position: absolute;
    top: 0;
    left: 0;
    z-index: -1;

}

@media (max-width: 991px )
{
    .contact {
        padding: 50px
    }

    .container {
        flex-direction: column;
    }
    .container .contactinfo{
        margin-bottom: 40px;
    }
    .container .contactinfo,
    .contactform{
        width:100%;
    }

}



/*INDEX*/

.Icon-container{
    

}


.Temple{
    display: flex;
    justify-content: center;

}

.ICON{
width: 200px;
display: flex;
justify-content: space-around;
padding: 200px;
}

.BotonIndex{
    display: flex;
    justify-content: center;
}
.Entrar{

display: flex;
justify-content: center;
padding: 100px;
width: 65px;
height: 5px;
align-items: center;
background-color: rgb(144, 231, 224);
color: #fff;
border: none;
cursor: pointer;
padding: 15px;
transition-duration: 2s
}



.boton-index {
    color:rgb(255, 255, 255);
    font-family: "Mark Pro Medium";
    font-size: 16px;
    text-align: center;
    text-decoration: none;
    transition-property: all;
transition-duration: 2s
}

.Entrar:hover{
color: tomato;
transform: scale(1.1);

}

.VI {
    position: absolute;
    top: 0;
    left: 0;
    z-index: -1;
   
    
}




