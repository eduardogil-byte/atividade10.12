using System.Data.Common;

var dict = new Dictionary<string, int> { { "Realista", 0 }, { "Investigativo", 0 }, { "Artistico", 0 }, { "Social", 0 }, { "Empreendedor", 0 }, { "Convencional", 0 } };

// Console.WriteLine("QUESTIONÁRIO RIASEC");
// Console.WriteLine("Para cada item, marque o quanto você se identifica:");
// Console.WriteLine("0 – Nada a ver; 1 – Pouco; 2 – Parcialmente; 3 – Bastante; 4 – Totalmente");

// /* Realista */
// Console.WriteLine("Gosto de trabalhar com ferramentas, máquinas ou objetos.");
// adicionarDicionario("Realista");

// Console.WriteLine("Prefiro atividades práticas a discussões teóricas.");
// adicionarDicionario("Realista");

// Console.WriteLine("Gosto de consertar, montar ou construir coisas.");
// adicionarDicionario("Realista");

// Console.WriteLine("Prefiro ambientes organizados e tarefas manuais.");
// adicionarDicionario("Realista");

// /* Investigativo */

// Console.WriteLine("Gosto de resolver problemas complexos.");
// adicionarDicionario("Investigativo");

// Console.WriteLine("Tenho interesse em ciência, pesquisa ou experimentos.");
// adicionarDicionario("Investigativo");

// Console.WriteLine("Gosto de analisar informações e entender como as coisas funcionam.");
// adicionarDicionario("Investigativo");

// Console.WriteLine("Prefiro atividades que envolvam reflexão e lógica.");
// adicionarDicionario("Investigativo");

// /* Artístico */

// Console.WriteLine("Gosto de criar, desenhar, inventar ou expressar ideias.");
// adicionarDicionario("Artistico");

// Console.WriteLine("Prefiro atividades com liberdade e sem regras rígidas.");
// adicionarDicionario("Artistico");

// Console.WriteLine("Gosto de música, artes visuais, escrita ou atuação.");
// adicionarDicionario("Artistico");

// Console.WriteLine("Sou imaginativo(a) e busco formas diferentes de fazer as coisas.");
// adicionarDicionario("Artistico");

// /* Social */

// Console.WriteLine("Gosto de ajudar, orientar ou cuidar de pessoas.");
// adicionarDicionario("Social");

// Console.WriteLine("Tenho facilidade para ouvir e compreender os outros.");
// adicionarDicionario("Social");

// Console.WriteLine("Prefiro atividades que envolvem ensinar ou apoiar alguém.");
// adicionarDicionario("Social");

// Console.WriteLine("Gosto de trabalhar em equipe e apoiar o bem-estar coletivo.");
// adicionarDicionario("Social");

// /* Empreendedor */

// Console.WriteLine("Gosto de liderar, convencer ou motivar pessoas.");
// adicionarDicionario("Empreendedor");

// Console.WriteLine("Tenho iniciativa e gosto de tomar decisões.");
// adicionarDicionario("Empreendedor");

// Console.WriteLine("Prefiro desafios que envolvam resultados e metas.");
// adicionarDicionario("Empreendedor");

// Console.WriteLine("Gosto de criar projetos e colocar ideias em prática.");
// adicionarDicionario("Empreendedor");

// /* Convencional */

// Console.WriteLine("Gosto de organizar, planejar e manter tudo em ordem.");
// adicionarDicionario("Convencional");

// Console.WriteLine("Prefiro atividades com regras claras e rotina.");
// adicionarDicionario("Convencional");

// Console.WriteLine("Gosto de trabalhar com documentos, tabelas ou registros.");
// adicionarDicionario("Convencional");

// Console.WriteLine("Sou detalhista e cuidadoso(a) com informações.");
// adicionarDicionario("Convencional");


raquer();
var newDict = dict.OrderByDescending(kvp => kvp.Value).ToDictionary(kpv => kpv.Key, kpv => kpv.Value);

foreach (KeyValuePair<string, int> par in newDict)
{
    Console.WriteLine($"Chave: {par.Key}, Valor: {par.Value}");
}

string[] cursoRealista = new string[] { "Mecânica", "Automação", "Usinagem", "Eletricidade", "Plastico", "Costura" };
string[] cursoInvestigativo = new string[] { "Tecnologia da Informação", "Eletroeletrônica", "Manutenção", "Plastico" };
string[] cursoArtistico = new string[] { "Design de Produto", "Impressão 3D", "Comunicação Visual", "Costura" };
string[] cursoSocial = new string[] { "Segurança do Trabalho", "Educação", "Saúde Ocupacional" };
string[] cursoEmpreendedor = new string[] { "Gestão", "Vendas Técnicas", "Logística" };
string[] cursoConvencional = new string[] { "Administração", "Controle de Qualidade", "Planejamento" };
cursos();


void cursos()
{
    Console.WriteLine($"O perfil que mais se encaixa é {newDict.First().Key}");
    int contador = 0;
    KeyValuePair<string, int> valorSegundo = new KeyValuePair<string, int>();
    KeyValuePair<string, int> valorTerceiro = new KeyValuePair<string, int>();
    foreach (KeyValuePair<string, int> d in newDict)
    {
        if (contador == 1 || contador == 2)
        {
            Console.WriteLine($"O {contador + 1}° perfil que se encaixa é {d.Key}");
            if (contador == 1)
            {
                valorSegundo = d;
            }
            else if (contador == 2)
            {
                valorTerceiro = d;
                break;
            }
        }
        contador++;

    }
    Console.WriteLine($"O segundo perfil é {valorSegundo.Key}");
    Console.WriteLine($"O terceiro perfil é {valorTerceiro.Key}");
    Console.WriteLine("Mostrando os curso para você: ");
    Console.WriteLine($"o {newDict.First().Key} curso: ");
    testarCursos(newDict.First().Key);
    Console.WriteLine($"o s curso: ");
    testarCursos(valorSegundo.Key);
    Console.WriteLine($"o primeiro curso: ");
    testarCursos(valorTerceiro.Key);

}

void testarCursos(string curso)
{
    if (curso == "Realista")
    {
        for (int i = 0; i < cursoRealista.Length; i++)
        {
            Console.WriteLine($"- {cursoRealista[i]}");
        }
    }
    else if (curso == "Investigativo")
    {
        for (int i = 0; i < cursoInvestigativo.Length; i++)
        {
            Console.WriteLine($"- {cursoInvestigativo[i]}");
        }
    }
    else if (curso == "Artistico")
    {
        for (int i = 0; i < cursoArtistico.Length; i++)
        {
            Console.WriteLine($"- {cursoArtistico[i]}");
        }
    }
    else if (curso == "Social")
    {
        for (int i = 0; i < cursoSocial.Length; i++)
        {
            Console.WriteLine($"- {cursoSocial[i]}");
        }
    }
    else if (curso == "Empreendedor")
    {
        for (int i = 0; i < cursoEmpreendedor.Length; i++)
        {
            Console.WriteLine($"- {cursoEmpreendedor[i]}");
        }
    }
    else if (curso == "Convencional")
    {
        for (int i = 0; i < cursoConvencional.Length; i++)
        {
            Console.WriteLine($"- {cursoConvencional[i]}");
        }
    }
}


void raquer()
{
    dict["Realista"] += int.Parse(Console.ReadLine());
    dict["Investigativo"] += int.Parse(Console.ReadLine());
    dict["Artistico"] += int.Parse(Console.ReadLine());
    dict["Social"] += int.Parse(Console.ReadLine());
    dict["Empreendedor"] += int.Parse(Console.ReadLine());
    dict["Convencional"] += int.Parse(Console.ReadLine());
}

void adicionarDicionario(string chave)
{
    int valor = int.Parse(Console.ReadLine());
    if (!(valor >= 0 && valor <= 4))
    {
        while (true)
        {
            Console.WriteLine("Valor maior que o esperado, tente novamente");
            valor = int.Parse(Console.ReadLine());
            if (valor >= 0 && valor <= 4)
            {
                dict[chave] += valor;
                break;
            }
        }
    }
    else
    {
        dict[chave] += valor;
    }
}

/* 
foreach (KeyValuePair<string, int> par in dict)
{
    Console.WriteLine($"Chave: {par.Key}, Valor: {par.Value}");
}
 */