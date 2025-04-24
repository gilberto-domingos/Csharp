import React, { useState } from 'react';
import { apiService } from '../services/apiService';

interface FormularioAutorProps {
  autorEdit?: any;
  onSuccess: () => void;
}

export const FormularioAutor: React.FC<FormularioAutorProps> = ({ autorEdit, onSuccess }) => {
  const [nome, setNome] = useState(autorEdit?.nome || '');
  const [sobrenome, setSobrenome] = useState(autorEdit?.sobrenome || '');

  const handleSubmit = async (e: React.FormEvent) => {
    e.preventDefault();
    const data = { nome, sobrenome };

    if (autorEdit) {
      await apiService.updateAutor(autorEdit.idAutor, data);
    } else {
      await apiService.createAutor(data);
    }

    setNome('');
    setSobrenome('');
    onSuccess(); 
  };

  return (
    <form onSubmit={handleSubmit}>
      <h2>{autorEdit ? 'Editar Autor' : 'Novo Autor'}</h2>
      <input
        type="text"
        placeholder="Nome"
        value={nome}
        onChange={(e) => setNome(e.target.value)}
      />
      <input
        type="text"
        placeholder="Sobrenome"
        value={sobrenome}
        onChange={(e) => setSobrenome(e.target.value)}
      />
      <button type="submit">{autorEdit ? 'Atualizar' : 'Cadastrar'}</button>
    </form>
  );
};
