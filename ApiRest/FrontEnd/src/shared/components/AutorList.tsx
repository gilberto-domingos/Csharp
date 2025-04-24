import React, { useEffect, useState } from 'react';
import { listarAutores } from '../services/autorService';
import { AutorModel } from '../types/autorTypes';
import { Typography, List, ListItem, ListItemText, Paper } from '@mui/material';

export const AutorList: React.FC = () => {
  const [autores, setAutores] = useState<AutorModel[]>([]);

  useEffect(() => {
    listarAutores().then((res) => {
      if (res.data.sucesso) {
        setAutores(res.data.dados);
      }
    });
  }, []);

  return (
    <Paper sx={{ p: 2, mt: 2 }}>
      <Typography variant="h6">Lista de Autores</Typography>
      <List>
        {autores.map((autor) => (
          <ListItem key={autor.id}>
            <ListItemText primary={autor.nome} secondary={`Nascimento: ${autor.dataNascimento}`} />
          </ListItem>
        ))}
      </List>
    </Paper>
  );
};
