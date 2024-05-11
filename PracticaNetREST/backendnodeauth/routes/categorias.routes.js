const router = require('express').Router();
const categorias = require('../controllers/categorias.controller');
const Authorize = require('../middleware/auth.middleware')
const RegistrarEnBitacora = require('../middleware/bitacoras.middleware')

const titulo = "Categorias"

router.get('/', Authorize('Administrador'), categorias.getAll);

router.get('/:id', Authorize('Administrador'), categorias.get);

router.post('/', Authorize('Administrador'), RegistrarEnBitacora(titulo, "POST"), categorias.create);

router.put('/:id',Authorize('Administrador'), RegistrarEnBitacora(titulo, "PUT"), categorias.update);

router.delete('/:id',Authorize('Administrador'), RegistrarEnBitacora(titulo, "DELETE"), categorias.delete);

module.exports = router

