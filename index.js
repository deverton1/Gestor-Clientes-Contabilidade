$(document).ready(function () {
    // Adiciona a máscara ao campo CNPJ
    $('#cnpj').mask('00.000.000/0000-00');

    // Adiciona evento de clique ao botão de consulta
    $('#consultarBtn').click(function () {
        // Obtém o CNPJ do campo
        const cnpj = $('#cnpj').val().replace(/\D/g, '');

        // Verifica se o CNPJ possui 14 dígitos
        if (cnpj.length === 14) {
            // Realiza a consulta à API
            consultarCNPJ(cnpj);
        } else {
            alert('CNPJ inválido. Por favor, verifique o formato.');
        }
    });
});

// Função para consultar o CNPJ
function consultarCNPJ(cnpj) {
    const apiUrl = `https://publica.cnpj.ws/cnpj/${cnpj}`;

    // Realiza a requisição à API
    $.ajax({
        url: apiUrl,
        type: 'GET',
        dataType: 'json',
        success: function (data) {
            // Lida com os dados da resposta da API
            exibirResultados(data);
        },
        error: function (error) {
            console.error('Erro na consulta CNPJ:', error);
            alert('Erro na consulta CNPJ. Por favor, tente novamente.');
        }
    });
}
// Função para exibir os resultados
function exibirResultados(data) {
    // Adapte conforme necessário para mapear os campos no HTML
    $('#razaoSocial').val(data.razao_social);

    // Vamos verificar se há sócios antes de acessar os dados
    if (data.socios && data.socios.length > 0) {
        // Considerando apenas o primeiro sócio
        const primeiroSocio = data.socios[0];
        $('#nomeRepresentante').val(primeiroSocio.nome || '');
        //$('#cpfRepresentante').val(primeiroSocio.cpf_cnpj_socio || ''); não consegui puxar os dados do cpf sem o asterisco
    }

    // condição pra ver se tem informações no CNPJ
    if (data.estabelecimento) {
        const estabelecimento = data.estabelecimento;

        // Verifica se o logradouro existe antes de atribuir o valor
        const logradouro = estabelecimento.logradouro || '';

        // Concatena as partes do endereço em uma única linha
        const enderecoCompleto = [logradouro, estabelecimento.numero, estabelecimento.complemento, estabelecimento.bairro]
            .filter(part => part)  // Remove partes nulas ou indefinidas
            .join(', ');

        $('#logradouro').val(enderecoCompleto);

        $('#tributacao').val(estabelecimento.natureza_juridica && estabelecimento.natureza_juridica.descricao || '');
        $('#porte').val(estabelecimento.porte && estabelecimento.porte.descricao || '');

        // Verifica se a data de abertura existe antes de formatar
        const dataAbertura = estabelecimento.data_inicio_atividade ? formatarData(estabelecimento.data_inicio_atividade) : '';
        $('#dataAbertura').val(dataAbertura);

    }
}
