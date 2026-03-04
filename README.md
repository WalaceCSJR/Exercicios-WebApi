# WebApi

Exercícios:

1 - Construa um programa webapi, com suprote para controllers.

2 - Construa um método httpget que, ao acessar a URL retorna a o número 10.

3 - Construa um método hettpget que, ao acessar a URL retorne um número randomico entre 1 e 100.

4 - Construa um método httpget que, ao acessar a URL ele retorne a data, horas, minutos e segundos de hoje.

5 - Construa um método httpget que, ao acessar a url ele retorne a data de hoje com um espaço mais um numero randomico do lado.

6 - Construa um método httpGet que, passando no parametro o nome, do tipo string, retorne o nome na tela.

7 - Construa um método httpGet que, passando o nome no primeiro parametro e a idade no segundo parametro ele retorne a frase: "O 'parametroNome' tem 'parametroIdade' anos". E, se passar a idade com 1 ano de dade, ele retorna a palavra "anos" no singular.

8 - Contrua um método httpGet que, passando o parametro de idade, ele retorne:
Se a idade for maior e igual do que 20, ele retorna o texto: Pode entrar no cinema.
Se a idade for menor que 20, ele retorne o texto: Você não está liberado para acessar o cinema.

9 - Construa um método httpPost que, passando um parâmetro FromQuery, que deve ser a idade, ele mostre no retorno do console a idade passada.

10 - Constroa um método HttpDelete que, passando o ID, do tipo inteiro no parâmetro FromQuery, ele retorne: "O usuário do id 'ID' foi deletado".


Novos Exercicios

1:
- Criar um método http post para enviar um objeto(dados de uma pessoa[nome e idade]) json pelo body. Este método deve retornar o objeto do tipo IActionResult
- Criar uma classe DTO para receber os dados de uma pessoa pelo httpPost
- retornar o DTO (onde o net webapi converterá para json) com todos os dados recebidos.


2:
- Criar um método http post para enviar um objeto(dados de uma pessoa[idade]) json pelo body. Este método deve retornar o objeto do tipo IActionResult
- Criar uma classe DTO para receber os dados de uma pessoa pelo httpPost
- Criar uma classe chamada PessoaService e implementar(a lógica) nessa classe o método que verifica se pessoa é de maior ou de menor. Se for de maior, retorna "true", se for de menor retorna "false".
- 

3:
- Criar um método http post para enviar um objeto(dados de uma pessoa[nome, sobrenome, data de nascimento) json pelo body. Este método deve retornar o objeto do tipo IActionResult
- Criar uma classe DTO para receber os dados de uma pessoa pelo httpPost
- Criar uma classe chamada pessoaService e implementar a lógica:
Se o nome for vazio, retornar: Nome vazio
Se o sobrenome for vazio, retornar: Sobrenome vazio
Se a idade for menor que 18 anos, retornar: Não é possível dar seguimento. (NOME) é de menor.
Se o dia e o mes forem os mesmos que hoje, então retornar: FEliz aniversário!
