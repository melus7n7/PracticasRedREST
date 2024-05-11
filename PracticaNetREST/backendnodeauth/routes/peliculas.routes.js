const router = require('express').Router();
const peliculas = require('../controllers/peliculas.controller')
const Authorize = require('../middleware/auth.middleware')
const RegistrarEnBitacora = require('../middleware/bitacoras.middleware')

const titulo = "Peliculas"

router.get('/', Authorize('Usuario,Administrador'), peliculas.getAll);

router.get('/:id', Authorize('Usuario,Administrador'), peliculas.get);

router.post('/', Authorize('Administrador'), RegistrarEnBitacora(titulo, "POST"), peliculas.create);

router.put('/:id', Authorize('Administrador'), RegistrarEnBitacora(titulo, "PUT"), peliculas.update);

router.delete('/:id', Authorize('Administrador'), RegistrarEnBitacora(titulo, "DELETE"), peliculas.delete);

router.post('/:id/categoria', Authorize('Administrador'), RegistrarEnBitacora(titulo + "-Categoria", "POST"), peliculas.asignaCategoria);

router.delete('/:id/categoria/:idcategoria', Authorize('Administrador'),  RegistrarEnBitacora(titulo + "-Categoria", "DELETE"),peliculas.eliminaCategoria);

module.exports = router