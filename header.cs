.cabeçalho__menu-hamburguer {
    width: 24px;
    height: 24px;
    display: inline-block;
    background-image: url("../img/Menu.svg");
    background-repeat: no-repeat;
    background-position: center;
}

.container__botao:checked~.container__rotulo>.cabeçalho__menu-hamburguer {
    background-image: url("../img/MenuAberto.svg");
}

.container__botao:checked~.container__rotulo {
    background: var(--azul-degrade);
}

.cabeçalho {
    background-color: var(--branco);
    display: flex;
    justify-content: space-between;
    align-items: center;
    position: relative;
}

.container {
    display: flex;
    align-items: center;
}

.container__imagem {
    padding: 1em;
}


.lista-menu {
    display: none;
    position: absolute;
    top: 100%;
    width: 60vw;
}

.container__botao:checked~.lista-menu {
    display: block;
}

.lista-menu__titulo,
.lista-menu__item {
    padding: 1em;
    background-color: var(--branco);
}

.lista-menu__titulo {
    color: var(--laranja);
    font-weight: 700;
}

.lista-menu__link {
    background: var(--azul-degrade);
    -webkit-background-clip: text;
    -webkit-text-fill-color: transparent;
    background-clip: text;
    text-transform: uppercase;
}

.container__botao {
    display: none;
}

.container__titulo {
    display: none;
}

.container__texto {
    display: none;
}

.opções {
    display: none
}

@media screen and (min-width: 1024px) {

    .container__titulo,
    .container__titulo--negrito {
        font-family: var(--fonte-secundario);
        font-size: 30px;
    }

    .container__titulo {
        font-weight: 400;
        display: block;
    }

    .container__titulo--negrito {
        font-weight: 700;
    }

    .opções {
        display: flex;
    }

    .opções__item {
        padding: 0 1em;
        text-transform: uppercase;
    }

    .opções__link {
        text-decoration: none;
        color: var(--preto);
    }

    .container__imagem-transparente {
        display: none;
    }

    .cabeçalho__menu-hamburguer {
        display: none;
    }

    .opções__botão:checked~.lista-menu {
        display: block;
        width: auto;
    }

    .opções__botão {
        display: none;
    }

    .opções__botão:checked~.opções__rotulo>.opções__item {
        background: var(--azul-degrade);
        color: var(--branco);
    }

    .opções__item {
        padding: 2em 1em;
    }

    .lista-menu__item:hover {
        background: var(--azul-degrade);
    }

    .lista-menu__item:hover>.lista-menu__link {
        -webkit-text-fill-color: var(--branco);
        text-decoration: none;
    }

}

@media screen and (min-width: 1728px) {
    .container__link {
        display: flex;
        align-items: center;
        text-decoration: none;
        color: var(--preto);
        padding-right: 30px;
    }

    .opções {
        margin-right: auto;
    }

    .container__texto {
        display: block;
    }

}