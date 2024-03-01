﻿$(document).ready(function () {

    $('.glyphicon-calendar').closest("div.date").datepicker({
        todayBtn: "linked",
        keyboardNavigation: false,
        forceParse: false,
        calendarWeeks: false,
        format: 'dd/mm/yyyy',
        autoclose: true,
        language: 'pt-BR'
    });

    $('#btnCancelar').click(function () {
        Swal.fire({
            html: "Deseja cancelar essa operação? O registro não será salvo.",
            type: "warning",
            showCancelButton: true,
        }).then(function (result) {
            if (result.value) {
                history.back();
            } else {
                console.log("Cancelou a inclusão.");
            }
        });
    });

    //$.ajax({
    //    type: 'GET',
    //    url: config.contextPath + 'Chamados/ObterListaAutocompleteSolicitantes',
    //    success: function (data) {
    //        $("#SolicitanteComplete").select2({
    //            data: data,
    //            placeholder: 'Selecione um item',
    //            allowClear: true
    //        });
    //    },
    //    error: function (error) {
    //        console.error('Erro ao obter a lista de autocompletar:', error);
    //    }
    //});

    //var url = config.contextPath + 'Chamados/ObterListaAutocompleteSolicitantes';

    //$('#fget').typeahead({
    //    source: function (query, process) {
    //        get(url, query, process);
    //    },
    //    minLength: 2, 
    //    afterSelect: function (item) {
    //        $("#idget").val(item);
    //    }
    //});

    //function get(url, query, process) {
    //    $.getJSON(url, query, function (response) {
    //        process(response);
    //    });
    //}

    $('#btnSalvar').click(function () {

        if ($('#form').valid() != true) {
            FormularioInvalidoAlert();
            return;
        }

        let chamado = SerielizeForm($('#form'));
        let url = $('#form').attr('action');
        //debugger;

        $.ajax({
            type: "POST",
            url: url,
            data: chamado,
            success: function (result) {

                Swal.fire({
                    type: result.Type,
                    title: result.Title,
                    text: result.Message,
                }).then(function () {
                    window.location.href = config.contextPath + result.Controller + '/' + result.Action;
                });

            },
            error: function (result) {

                 Swal.fire({
                    text: result.responseJSON['Message'],
                    confirmButtonText: 'OK',
                    icon: 'error'
                });

            },
        });
    });

});
