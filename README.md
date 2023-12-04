# Semestral
Este documento tem como objetivo explicar a abordagem e os conceitos de Programação Orientada a Objetos (POO) utilizados no código fornecido.

Classes e Objetos:
	As classes são estruturas que encapsulam dados (atributos) e comportamentos (métodos) relacionados.
	ItemBiblioteca é uma classe abstrata que encapsula atributos comuns a todos os itens de biblioteca.
	Livro é uma classe derivada de ItemBiblioteca que herda seus atributos e métodos.

Encapsulamento:
	A propriedade DescricaoInterna da classe ItemBiblioteca é marcada como protegida, encapsulando seu acesso direto e permitindo seu uso apenas nas classes derivadas.

Herança:
	Livro herda de ItemBiblioteca, permitindo que compartilhe atributos e comportamentos da classe base. A herança ajuda a reutilizar código e estabelecer uma hierarquia de classes.

Polimorfismo:
	O método ExibirDescricaoInterna na classe Livro demonstra polimorfismo ao sobrescrever o método InicializarDescricaoInterna da classe base.

Abstração:
	A classe ItemBiblioteca é uma abstração, representando conceitos genéricos de itens de biblioteca. Métodos abstratos podem ser sobrescritos em classes derivadas.

Composição:
	A classe Biblioteca contém uma coleção de ItemBiblioteca. Essa relação de composição permite que uma biblioteca seja composta por vários itens.

Ajustes no Código:
	A classe Biblioteca não herda mais de ItemBiblioteca, pois uma biblioteca não é um tipo de item de biblioteca. Essa mudança evita confusões conceituais.

Considerações Adicionais:
	O código segue práticas de POO, promovendo a modularidade, reutilização de código e facilitando a manutenção.

A abordagem adotada no código demonstra um uso apropriado dos princípios de POO, como encapsulamento, herança, polimorfismo, abstração e composição. Cada conceito é aplicado para criar uma estrutura robusta e flexível que modela eficazmente o domínio do sistema.
