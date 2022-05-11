<div class="container">
    <div class="row pt-5">
        <form method="post" action="./formations">
            <select name="selectCompetence" class="form-select" aria-label="Default select example">
                <option selected>Choisir une Catégorie</option>
                <?php

                foreach ($competences as $competence) {
                    echo('<option value="' . $competence["IDCOMPETENCE"] . '">' . $competence["LIBELLECOMPETENCE"] . '</option>');
                }
                ?>

            </select>
            <div class="text-center p-3">
                <input class="d-lg-inline-block ml-3 btn btn-danger" type="submit" value="valider la catégorie" >
            </div>
        </form>
        <?php
        foreach ($formations as $formation) {
            ?>

            <div class="col-sm-12 p-3">
                <div class="card card-hover">
                    <div class="card-body d-flex">
                        <div class="p-3">
                            <img class="preview-image" src="<?= $formation["IMAGE"] ?>">
                        </div>
                        <div class="p-3 flex-grow-1">
                            <h5 class="mb-0 pb-0"><?= $formation['LIBELLE']; ?></h5>
                            <p><?= $formation['DESCRIPTION'] ?></p>
                            <a href="./tv?id=<?= $formation['IDENTIFIANTVIDEO'] ?>" class="btn btn-outline-primary">Voir
                                la formation →</a>
                        </div>
                    </div>
                </div>
            </div>

            <?php
        }
        ?>
    </div>
</div>