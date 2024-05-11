const router = require('express').Router();
const usuarios = require('../controllers/usuarios.controller')
const Authorize = require('../middleware/auth.middleware')
const RegistrarEnBitacora = require('../middleware/bitacoras.middleware')

const titulo = "Usuarios"

router.get('/', Authorize('Administrador'), usuarios.getAll);

router.get('/:email',Authorize('Administrador'), usuarios.get);

router.post('/', Authorize('Administrador'), RegistrarEnBitacora(titulo, "POST"), usuarios.create);

router.put('/:email', Authorize('Administrador'), RegistrarEnBitacora(titulo, "PUT"), usuarios.update);

router.delete('/:email', Authorize('Administrador'), RegistrarEnBitacora(titulo, "DELETE"), usuarios.delete);

module.exports = router