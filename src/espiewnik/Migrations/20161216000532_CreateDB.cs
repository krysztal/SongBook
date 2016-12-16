using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace espiewnik.Migrations
{
    public partial class CreateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Categories_PerentId",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriesSongs_Categories_CategoryId",
                table: "CategoriesSongs");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriesSongs_Songs_SongId",
                table: "CategoriesSongs");

            migrationBuilder.DropForeignKey(
                name: "FK_Elaborations_Songs_SongId",
                table: "Elaborations");

            migrationBuilder.DropForeignKey(
                name: "FK_ElaborationsComposers_Composers_ComposerId",
                table: "ElaborationsComposers");

            migrationBuilder.DropForeignKey(
                name: "FK_ElaborationsComposers_Elaborations_ElaborationId",
                table: "ElaborationsComposers");

            migrationBuilder.DropForeignKey(
                name: "FK_Files_Elaborations_ElaborationId",
                table: "Files");

            migrationBuilder.DropForeignKey(
                name: "FK_Files_Scops_ScopeId",
                table: "Files");

            migrationBuilder.DropForeignKey(
                name: "FK_Files_FileTypes_TypeId",
                table: "Files");

            migrationBuilder.DropForeignKey(
                name: "FK_Scops_Instruments_InstrumentId",
                table: "Scops");

            migrationBuilder.DropForeignKey(
                name: "FK_Scops_Elaborations_VoiceId",
                table: "Scops");

            migrationBuilder.DropForeignKey(
                name: "FK_Scops_Voices_VoiceId",
                table: "Scops");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Voices",
                table: "Voices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Songs",
                table: "Songs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Scops",
                table: "Scops");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Instruments",
                table: "Instruments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FileTypes",
                table: "FileTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Files",
                table: "Files");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ElaborationsComposers",
                table: "ElaborationsComposers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Elaborations",
                table: "Elaborations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Composers",
                table: "Composers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CategoriesSongs",
                table: "CategoriesSongs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "Voices",
                newName: "Voice");

            migrationBuilder.RenameTable(
                name: "Songs",
                newName: "Song");

            migrationBuilder.RenameTable(
                name: "Scops",
                newName: "Scope");

            migrationBuilder.RenameTable(
                name: "Instruments",
                newName: "Instrument");

            migrationBuilder.RenameTable(
                name: "FileTypes",
                newName: "FileType");

            migrationBuilder.RenameTable(
                name: "Files",
                newName: "File");

            migrationBuilder.RenameTable(
                name: "ElaborationsComposers",
                newName: "ElaborationComposer");

            migrationBuilder.RenameTable(
                name: "Elaborations",
                newName: "Elaboration");

            migrationBuilder.RenameTable(
                name: "Composers",
                newName: "Composer");

            migrationBuilder.RenameTable(
                name: "CategoriesSongs",
                newName: "CategorySong");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "Category");

            migrationBuilder.RenameIndex(
                name: "IX_Scops_VoiceId",
                table: "Scope",
                newName: "IX_Scope_VoiceId");

            migrationBuilder.RenameIndex(
                name: "IX_Scops_InstrumentId",
                table: "Scope",
                newName: "IX_Scope_InstrumentId");

            migrationBuilder.RenameIndex(
                name: "IX_Files_TypeId",
                table: "File",
                newName: "IX_File_TypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Files_ScopeId",
                table: "File",
                newName: "IX_File_ScopeId");

            migrationBuilder.RenameIndex(
                name: "IX_Files_ElaborationId",
                table: "File",
                newName: "IX_File_ElaborationId");

            migrationBuilder.RenameIndex(
                name: "IX_ElaborationsComposers_ElaborationId",
                table: "ElaborationComposer",
                newName: "IX_ElaborationComposer_ElaborationId");

            migrationBuilder.RenameIndex(
                name: "IX_ElaborationsComposers_ComposerId",
                table: "ElaborationComposer",
                newName: "IX_ElaborationComposer_ComposerId");

            migrationBuilder.RenameIndex(
                name: "IX_Elaborations_SongId",
                table: "Elaboration",
                newName: "IX_Elaboration_SongId");

            migrationBuilder.RenameIndex(
                name: "IX_CategoriesSongs_SongId",
                table: "CategorySong",
                newName: "IX_CategorySong_SongId");

            migrationBuilder.RenameIndex(
                name: "IX_CategoriesSongs_CategoryId",
                table: "CategorySong",
                newName: "IX_CategorySong_CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Categories_PerentId",
                table: "Category",
                newName: "IX_Category_PerentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Voice",
                table: "Voice",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Song",
                table: "Song",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Scope",
                table: "Scope",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Instrument",
                table: "Instrument",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FileType",
                table: "FileType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_File",
                table: "File",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ElaborationComposer",
                table: "ElaborationComposer",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Elaboration",
                table: "Elaboration",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Composer",
                table: "Composer",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CategorySong",
                table: "CategorySong",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                table: "Category",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Category_Category_PerentId",
                table: "Category",
                column: "PerentId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CategorySong_Category_CategoryId",
                table: "CategorySong",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategorySong_Song_SongId",
                table: "CategorySong",
                column: "SongId",
                principalTable: "Song",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Elaboration_Song_SongId",
                table: "Elaboration",
                column: "SongId",
                principalTable: "Song",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ElaborationComposer_Composer_ComposerId",
                table: "ElaborationComposer",
                column: "ComposerId",
                principalTable: "Composer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ElaborationComposer_Elaboration_ElaborationId",
                table: "ElaborationComposer",
                column: "ElaborationId",
                principalTable: "Elaboration",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_File_Elaboration_ElaborationId",
                table: "File",
                column: "ElaborationId",
                principalTable: "Elaboration",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_File_Scope_ScopeId",
                table: "File",
                column: "ScopeId",
                principalTable: "Scope",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_File_FileType_TypeId",
                table: "File",
                column: "TypeId",
                principalTable: "FileType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Scope_Instrument_InstrumentId",
                table: "Scope",
                column: "InstrumentId",
                principalTable: "Instrument",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Scope_Elaboration_VoiceId",
                table: "Scope",
                column: "VoiceId",
                principalTable: "Elaboration",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Scope_Voice_VoiceId",
                table: "Scope",
                column: "VoiceId",
                principalTable: "Voice",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Category_Category_PerentId",
                table: "Category");

            migrationBuilder.DropForeignKey(
                name: "FK_CategorySong_Category_CategoryId",
                table: "CategorySong");

            migrationBuilder.DropForeignKey(
                name: "FK_CategorySong_Song_SongId",
                table: "CategorySong");

            migrationBuilder.DropForeignKey(
                name: "FK_Elaboration_Song_SongId",
                table: "Elaboration");

            migrationBuilder.DropForeignKey(
                name: "FK_ElaborationComposer_Composer_ComposerId",
                table: "ElaborationComposer");

            migrationBuilder.DropForeignKey(
                name: "FK_ElaborationComposer_Elaboration_ElaborationId",
                table: "ElaborationComposer");

            migrationBuilder.DropForeignKey(
                name: "FK_File_Elaboration_ElaborationId",
                table: "File");

            migrationBuilder.DropForeignKey(
                name: "FK_File_Scope_ScopeId",
                table: "File");

            migrationBuilder.DropForeignKey(
                name: "FK_File_FileType_TypeId",
                table: "File");

            migrationBuilder.DropForeignKey(
                name: "FK_Scope_Instrument_InstrumentId",
                table: "Scope");

            migrationBuilder.DropForeignKey(
                name: "FK_Scope_Elaboration_VoiceId",
                table: "Scope");

            migrationBuilder.DropForeignKey(
                name: "FK_Scope_Voice_VoiceId",
                table: "Scope");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Voice",
                table: "Voice");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Song",
                table: "Song");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Scope",
                table: "Scope");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Instrument",
                table: "Instrument");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FileType",
                table: "FileType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_File",
                table: "File");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ElaborationComposer",
                table: "ElaborationComposer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Elaboration",
                table: "Elaboration");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Composer",
                table: "Composer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CategorySong",
                table: "CategorySong");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

            migrationBuilder.RenameTable(
                name: "Voice",
                newName: "Voices");

            migrationBuilder.RenameTable(
                name: "Song",
                newName: "Songs");

            migrationBuilder.RenameTable(
                name: "Scope",
                newName: "Scops");

            migrationBuilder.RenameTable(
                name: "Instrument",
                newName: "Instruments");

            migrationBuilder.RenameTable(
                name: "FileType",
                newName: "FileTypes");

            migrationBuilder.RenameTable(
                name: "File",
                newName: "Files");

            migrationBuilder.RenameTable(
                name: "ElaborationComposer",
                newName: "ElaborationsComposers");

            migrationBuilder.RenameTable(
                name: "Elaboration",
                newName: "Elaborations");

            migrationBuilder.RenameTable(
                name: "Composer",
                newName: "Composers");

            migrationBuilder.RenameTable(
                name: "CategorySong",
                newName: "CategoriesSongs");

            migrationBuilder.RenameTable(
                name: "Category",
                newName: "Categories");

            migrationBuilder.RenameIndex(
                name: "IX_Scope_VoiceId",
                table: "Scops",
                newName: "IX_Scops_VoiceId");

            migrationBuilder.RenameIndex(
                name: "IX_Scope_InstrumentId",
                table: "Scops",
                newName: "IX_Scops_InstrumentId");

            migrationBuilder.RenameIndex(
                name: "IX_File_TypeId",
                table: "Files",
                newName: "IX_Files_TypeId");

            migrationBuilder.RenameIndex(
                name: "IX_File_ScopeId",
                table: "Files",
                newName: "IX_Files_ScopeId");

            migrationBuilder.RenameIndex(
                name: "IX_File_ElaborationId",
                table: "Files",
                newName: "IX_Files_ElaborationId");

            migrationBuilder.RenameIndex(
                name: "IX_ElaborationComposer_ElaborationId",
                table: "ElaborationsComposers",
                newName: "IX_ElaborationsComposers_ElaborationId");

            migrationBuilder.RenameIndex(
                name: "IX_ElaborationComposer_ComposerId",
                table: "ElaborationsComposers",
                newName: "IX_ElaborationsComposers_ComposerId");

            migrationBuilder.RenameIndex(
                name: "IX_Elaboration_SongId",
                table: "Elaborations",
                newName: "IX_Elaborations_SongId");

            migrationBuilder.RenameIndex(
                name: "IX_CategorySong_SongId",
                table: "CategoriesSongs",
                newName: "IX_CategoriesSongs_SongId");

            migrationBuilder.RenameIndex(
                name: "IX_CategorySong_CategoryId",
                table: "CategoriesSongs",
                newName: "IX_CategoriesSongs_CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Category_PerentId",
                table: "Categories",
                newName: "IX_Categories_PerentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Voices",
                table: "Voices",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Songs",
                table: "Songs",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Scops",
                table: "Scops",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Instruments",
                table: "Instruments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FileTypes",
                table: "FileTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Files",
                table: "Files",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ElaborationsComposers",
                table: "ElaborationsComposers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Elaborations",
                table: "Elaborations",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Composers",
                table: "Composers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CategoriesSongs",
                table: "CategoriesSongs",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Categories_PerentId",
                table: "Categories",
                column: "PerentId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriesSongs_Categories_CategoryId",
                table: "CategoriesSongs",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriesSongs_Songs_SongId",
                table: "CategoriesSongs",
                column: "SongId",
                principalTable: "Songs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Elaborations_Songs_SongId",
                table: "Elaborations",
                column: "SongId",
                principalTable: "Songs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ElaborationsComposers_Composers_ComposerId",
                table: "ElaborationsComposers",
                column: "ComposerId",
                principalTable: "Composers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ElaborationsComposers_Elaborations_ElaborationId",
                table: "ElaborationsComposers",
                column: "ElaborationId",
                principalTable: "Elaborations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Files_Elaborations_ElaborationId",
                table: "Files",
                column: "ElaborationId",
                principalTable: "Elaborations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Files_Scops_ScopeId",
                table: "Files",
                column: "ScopeId",
                principalTable: "Scops",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Files_FileTypes_TypeId",
                table: "Files",
                column: "TypeId",
                principalTable: "FileTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Scops_Instruments_InstrumentId",
                table: "Scops",
                column: "InstrumentId",
                principalTable: "Instruments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Scops_Elaborations_VoiceId",
                table: "Scops",
                column: "VoiceId",
                principalTable: "Elaborations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Scops_Voices_VoiceId",
                table: "Scops",
                column: "VoiceId",
                principalTable: "Voices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
