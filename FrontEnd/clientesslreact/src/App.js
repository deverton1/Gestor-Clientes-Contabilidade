import React, { useState, useEffect } from 'react';
import 'bootstrap/dist/css/bootstrap.min.css';
import axios from 'axios';
import { Modal, ModalBody, ModalFooter, ModalHeader } from 'reactstrap';
//import logo from './logo.svg';
import './App.css';

function App() {

  const baseUrl = "https://localhost:7009/api/Empresas/Listar-Empresas"
  const [data, setData] = useState([]);
  const pedidoGet = async () => {
    await axios.get(baseUrl)
      .then(response => {
        setData(response.data);
      }).catch(error => {
        console.log(error);
      })
  }
  useEffect(() => {
    pedidoGet();
  })

  return (
    <div className="App">
      <br />
      <h3>GERENTE DE EMPRESAS SL</h3>
      <header className="App-header">
        <table className='table table-bordered'>
          <thead>
            <tr>
              <th>Id</th>
              <th>CNPJ</th>
              <th>Razão Social</th>
              <th>Representante</th>
              <th>CPF do Representante</th>
              <th>Código Simples Nacional</th>
              <th>Logradouro</th>
              <th>Tributação</th>
              <th>Porte</th>
              <th>Data de Abertura</th>
            </tr>
          </thead>
          <tbody>
            {data.map(empresas => (
              <tr key={empresas.Id}>
                <td>{empresas.id}</td>
                <td>{empresas.razaosocial}</td>
                <td>{empresas.cnpj}</td>
                <td>{empresas.representante}</td>
                <td>{empresas.cpfrepresentante}</td>
                <td>{empresas.codigosimplesnacional}</td>
                <td>{empresas.logradouro}</td>
                <td>{empresas.tributacao}</td>
                <td>{empresas.porte}</td>
                <td>{empresas.dataabertura}</td>
                <td>
                  <button className='btn btn-primary'>Editar</button>{"   "}
                  <button className='btn btn-danger'>Excluir</button>
                </td>
              </tr>
            ))}
          </tbody>
        </table>
      </header>
    </div>
  );
}

export default App;
