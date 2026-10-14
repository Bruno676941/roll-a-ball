Nome do projeto:
 roll-a-ball
Aluno: 
 Bruno Carvalho 
Turma:
 2026.29.09
Feito com:
 Unity 6 
 C#
Sobre o projeto:
 Temos um personagem que é um pequeno buraco negro
 que busca "engolir" pequenos planetinhas.
O que o projeto faz: 
 o jogador movimenta o personagem com as setas/WASD 
 e quando colide com os planetinhas ele os destroi
Cenas:
 Espaço: um bloco muito grande e transparente, mas
 com a imagem de fundo de um espaço
Scripts: 
  gerenciadorDeJogo:
  define todo o sistema de contagem de pontos 
  (basicamente contar e atualizar texto)
  movimento:
  define teclas de movimento e salto, junto a isso define velocidade de rolagem,
  além disso define condição de vitória(que é pegar 12 planetinhas)
  rotator:
  faz objetos coletáveis ficarem rodando 
  girar:
  script que eu criei para simular a luz rodando em volta do buraco negro
  (no caso faze o cilindro achatado e acoplado na bola girar)
  coletavel:
  quando identifica colisão deleta o coletavel(vai no jogador)
  seguircamera:
  faz a câmera acompanhar o jogador
 Objetos principais:
 BuracoNegro(jogador)
  cilinder(disco rodando em volta da esafera)
  particle system( particulas da bola)

 plane(colisor do chão)
 
 blocos:
 Conjunto de blocos e cores para o cenário(colisão)

 planetinhas(coletavel)

 Diretional light(luz para o cenário)

 MainCamera(literalmente uma câmera que segue o jogador)

 Canva:
 usado para textos e pontuação (gerenciador de jogo para auxiliar)
Recursos usados:
   Rigidbody
   Collider com Is Trigger
   mesh collider
   capsule collider
   box collider
   character controler
   camera
   light
   halo

 Controles 
Setinhas/WASD:
movimentam o personagem nas 4 direções
leste,oeste,norte,sul

espaço:
faz o personagem pular
O que eu aprendi 
 Muita coisa, mas se for para resumir eu diria que C# orientado a objeto
 básico, mais lógica de programação, modelação básica no Blender, usar
 texturas na Unity e usar o Github um pouco melhor
## Como abrir
Baixe o projeto, abra o Unity Hub, clique em **Add** e escolha a pasta do projeto.
