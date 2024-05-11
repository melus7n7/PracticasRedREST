const router = require('express').Router();
const peliculas = require('../controllers/peliculas.controller')
const Authorize = require('../middleware/auth.middleware')


router.get('/', Authorize('Usuario,Administrador'), peliculas.getAll);

router.get('/:id', Authorize('Usuario,Administrador'), peliculas.get);

router.post('/', Authorize('Administrador'), peliculas.create);

router.put('/:id', Authorize('Administrador'), peliculas.update);

router.delete('/:id', Authorize('Administrador'), peliculas.delete);

router.post('/:id/categoria', Authorize('Administrador'), peliculas.asignaCategoria);

router.delete('/:id/categoria/:idcategoria', Authorize('Administrador'), peliculas.eliminaCategoria);

module.exports = router