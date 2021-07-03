Leonardo Vinicius Aguirre RGM 11181502271 6ºB SI

1.Descreva brevemente em quais pontos da sua modelagem e implementação você aplicou um ou mais dos princípios SOLID.
R- Apliquei o princípio de responsabilidade única onde cada classe é responsável em realizar apenas uma única operação.
O princípio de aberto/fechado onde as classes devem ser alteradas em si mesmas e modificações não alteram outras classes relacionadas 
E o princípio de substituição de liskov, onde os objetos podem ser substituídos por instâncias com seus respectivos subtipos de forma que o software continue apresentando resultados corretos

2.Quais Padrões de Projeto GoF foram aplicados na sua modelagem e implementação e quais problemas (de modelagem) foram resolvidos? 
R- Apliquei o padrão facade onde foi resolvido o problema da classe principal ter diversos métodos para executar regras de negócio que acabava criando um grande acoplamento entre a classe main e o restante das classes o que acaba criando dificuldades e problemas no caso de reuso ou manutenção do código posteriormente

3.Como você imagina a evolução desta plataforma em termos de funcionalidade e complexidade, e como a sua modelagem suportaria essas mudanças? 
R- Eu vejo que posteriormente se criará diversos perfis diferente para o gerenciamento dos processos seletivos além da inclusão de mais informações específicas sobre os processos e os candidatos além da adição de bibliotecas externas ao projeto por exemplo uma biblioteca de envios de SMS. através dos padrões facade e o adapter aplicados no projeto possibilita essa possíveis mudanças futuras.
