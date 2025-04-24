import React, { useEffect, useState } from 'react';
import {
  Container,
  Typography,
  List,
  ListItem,
  ListItemText,
  Button,
  Stack,
} from '@mui/material';
import { apiService } from '../shared/services/apiService';
import { FormularioAutor } from '../shared/components/FormularioAutor';
import { AutorType } from '../shared/types/autorTypes';


const Autores: React.FC = () => {
  const [autores, setAutores] = useState<AutorType[]>([]);
  const [autorEdit, setAutorEdit] = useState<AutorType | null>(null);

  const fetchAutores = async () => {
    try {
      const response = await apiService.getAutores();
      const data = response.dados; // 👈 acessa corretamente o array
      console.log('Autores recebidos:', data);
      setAutores(Array.isArray(data) ? data : []);
    } catch (error) {
      console.error('Erro ao buscar autores:', error);
    }
  };

  const handleDelete = async (id: number) => {
    await apiService.deleteAutor(id);
    setAutores((prev) => prev.filter((autor) => autor.idAutor !== id));
  };

  useEffect(() => {
    fetchAutores();
  }, []);

  return (
    <Container>
      <Typography variant="h4" sx={{ mt: 4 }}>
        Autores
      </Typography>

      <FormularioAutor
        autorEdit={autorEdit}
        onSuccess={() => {
          fetchAutores();
          setAutorEdit(null);
        }}
      />

      <List sx={{ mt: 4 }}>
        {autores.map((autor) => (
          <ListItem key={autor.idAutor} divider>
            <ListItemText primary={`${autor.nome} ${autor.sobrenome}`} />
            <Stack direction="row" spacing={1}>
              <Button variant="outlined" onClick={() => setAutorEdit(autor)}>
                Editar
              </Button>
              <Button
                variant="contained"
                color="error"
                onClick={() => handleDelete(autor.idAutor)}
              >
                Excluir
              </Button>
            </Stack>
          </ListItem>
        ))}
      </List>
    </Container>
  );
};

export default Autores;
