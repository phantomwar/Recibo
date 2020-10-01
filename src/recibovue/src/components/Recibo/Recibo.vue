<template>
  <div>
    <form>
      
      
      <div class="container">
        <!-- Form Name -->
        <div class="externa"><h1>Recibo</h1></div>
        
        <div class="form-row">
                  

          <!-- Text input Nome do Emissor-->

          <div class="form-group col-md-6">
            <label for="nomeEmitente">Nome do Emissor:</label>
            <input id="nomeEmitente" type="text" class="form-control" />
            <span class="help-block">Quem esta emitindo o recibo</span>
          </div>

          <!-- File Button -->

          <div class="col-md-6">
            <label for="logo">Logo</label>
            <input id="logo" class="input-file" type="file" />
          </div>

          <!-- Text inpu Documento do Emissor-->

          <div class="col-md-6 mb-3">
            <label for="documentoe">CPF ou CNPJ</label>
            <input
              id="documentoe"
              type="text"
              placeholder=""
              class="form-control"
            />
            <span class="help-block">Somente números</span>
          </div>

          <!-- Text inpu Documento do Emissor-->

          <div class="col-md-6 mb-3">
            <label for="tefefonee">Tefefone</label>
            <input
              id="tefefonee"
              type="text"
              placeholder=""
              class="form-control"
            />
          </div>
        </div>

        <div class="form-row">
                  

          <!-- Text input Nome do Pagador-->

          <div class="form-group col-md-6">
            <label for="nomePagador">Nome do Pagador:</label>
            <input id="nomePagador" type="text" class="form-control" />
            <span class="help-block">Destinatario do recibo</span>
          </div>

          <!-- Text inpu Documento do Pagador-->

          <div class="col-md-6 mb-3">
            <label for="documentop">CPF ou CNPJ</label>
            <input
              id="documentop"
              type="text"
              placeholder=""
              class="form-control"
            />
            <span class="help-block">Somente números</span>
          </div>

          <!-- Text inpu Referente-->

          <div class="col-md-12">
            <label for="referente">Referente à:</label>
            <input
              id="referente"
              type="text"
              placeholder=""
              class="form-control"
            />            
          </div>
          
          <!-- Text inpu Valor-->

          <div class="col-md-4">
            <label for="valor">Valor</label>
            <input
              id="valor"
              type="text"
              placeholder="00,00"
              class="form-control"
            />            
          </div>

          <!-- Text inpu Data-->

          <div class="col-md-4">
            <label for="data">Data</label>
            <input
              id="data"
              type="date"
              class="form-control"
            />            
          </div>

          <!-- Text inpu Cidade-->

          <div class="col-md-4">
            <label for="cidade">Cidade</label>
            <input
              id="cidade"
              type="text"
              class="form-control"
            />            
          </div>
        
        <!-- Text inpu Forma de Pagamento-->
          <div class="col-md-6 form-group">
            <label for="formaPagamento">Forma de Pagamento:</label>
            <select id="formaPagamento" class="custom-select" required>
                <option value="">Selecione</option>
                <option value="1">Dinheiro</option>
                <option value="2">Cheque</option>
                <option value="3">Transfeência/Depósito</option>
                <option value="4">Cartão</option>
            </select>
            <div class="invalid-feedback">Example invalid custom select feedback</div>
          </div>
        </div>
        <div class="row">
        <div class="col-md-3"><button class="btn btn-success btn-lg" type="submit">Salvar</button></div>
        <div class="col-md-3"><button class="btn btn-danger btn-lg" type="submit">Cancelar</button></div>
        <div class="col-md-3"><button class="btn btn-primary btn-lg" type="submit">Imprimir</button></div>
        </div>
      </div>
    </form>
  </div>
</template>

<script>
export default {
  name: "Recibo",
};
</script>

<style>
.externa {
  width: 90%;
  margin-top: 20px;
  margin-bottom: 20px;
  display: table;
  text-align: center;
  vertical-align: middle;
  display: table-cell;
}
.interna {
}
label{
    margin-top: 5px;
    font-weight:bolder;
    
}
</style>
